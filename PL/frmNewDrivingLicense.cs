using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace PL
{
    public partial class frmNewDrivingLicense : Form
    {
        public frmNewDrivingLicense()
        {
            InitializeComponent();
        }
        enum enStatus { New = 1, Canceled, Completed }

        enStatus Status = enStatus.New;

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            int PersonID = frm.PersonID;
            if (PersonID != -1) ctrlPersonInfoFilter1.fillForm(PersonID);

        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void frmNewDrivingLicense_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            cbClasses.DataSource = clsLicenseClass.getAll();
            cbClasses.DisplayMember = "ClassName";
            cbClasses.ValueMember = "LicenseClassID";
            clsApplicationType appType = clsApplicationType.getApplicationTypeByID(1);
            if (appType != null)
            {
                if((int)appType.ApplicationFees == appType.ApplicationFees) lblFees.Text = ((int)appType.ApplicationFees).ToString() + "$";
                else lblFees.Text = (appType.ApplicationFees).ToString() + "$";
            }

        }

        private int _CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;

            if (birthDate.Date > DateTime.Now.AddYears(-age))
                age--;

            return age;
        }

        private bool _check(int classID, int minAge)
        {
            if (clsLocalDrivingLicenseApplication.isLocalLicenseAppExistByPersonIDAndClassID(ctrlPersonInfoFilter1.PersonID, classID))
            {
                MessageBox.Show("Error: There is already an active application with the same license class.");
                return false;
            }
            if (ctrlPersonInfoFilter1.PersonID < 0)
            {
                MessageBox.Show("Error: Person Not Found.");
                return false;
            }

            clsPerson Person = clsPerson.getPersonByID(ctrlPersonInfoFilter1.PersonID);
            if (_CalculateAge(Person.DateOfBirth) < minAge)
            {
                MessageBox.Show("Error: Person Age is not allowed to own this License Class");
                return false;
            }

            clsDriver driver = clsDriver.getDriverByPersonID(ctrlPersonInfoFilter1.PersonID);
            if(driver != null)
            {
                if (clsLicense.isLicenseExistByDriverAndClassID(driver.DriverID, classID))
                {
                    MessageBox.Show($"Error: Cannot make this application because Person has License of this type already", "Person already have this class of license", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication licenseApplication = new clsLocalDrivingLicenseApplication();
            if (cbClasses.SelectedValue == null)
            {
                MessageBox.Show("You do not choose a license class");
                return;
            }
            clsLicenseClass lClass = clsLicenseClass.getLicenseClassByID((int)cbClasses.SelectedValue);
            if (!_check(lClass.LicenseClassID,  lClass.MinimumAllowedAge)) return;

            if (_save(licenseApplication, lClass.ClassFees))
            {

                MessageBox.Show("Application Added Successfully!.");
                btnSave.Enabled = false;
            }
            else MessageBox.Show("Application Save Failed.");

        }

        private bool _save(clsLocalDrivingLicenseApplication licenseApplication, decimal fees)
        {
            if (cbClasses.SelectedValue == null) return false;

            licenseApplication.LicenseClassID = (int)cbClasses.SelectedValue;
            licenseApplication.Application.ApplicationDate = DateTime.Now;
            licenseApplication.Application.LastStatusDate = DateTime.Now;
            licenseApplication.Application.Person.PersonID = ctrlPersonInfoFilter1.PersonID;
            licenseApplication.Application.ApplicationTypeID = 1; // New
            licenseApplication.Application.ApplicationStatus = (byte)Status;
            licenseApplication.Application.CreatedByUserID = clsHelper.user.UserID;
            licenseApplication.Application.PaidFees = fees;
            return licenseApplication.Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
