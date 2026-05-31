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
    public partial class frmIssueLicense : Form
    {
        public frmIssueLicense(int ldlaID)
        {
            InitializeComponent();
            _ldlaID = ldlaID;

        }
        int _ldlaID = -1;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool isIssued = false;

        private int _saveDriver(clsLocalDrivingLicenseApplication ldla)
        {
            clsDriver existingDriver = clsDriver.getDriverByPersonID(ldla.Application.Person.PersonID);

            if (existingDriver != null)
                return existingDriver.DriverID;

            clsDriver driver = new clsDriver();
            driver.CreatedDate = DateTime.Now;
            driver.CreatedByUserID = clsHelper.user.UserID;
            driver.Person = ldla.Application.Person;
            if (!driver.Save())
            {
                MessageBox.Show("Error in saving the new driver record");
                return -1;
            }
            return driver.DriverID;
        }

        private bool _saveLicense(clsLocalDrivingLicenseApplication ldla, int driverID)
        {
            clsLicense License = new clsLicense();
            clsLicenseClass licenseClass = clsLicenseClass.getLicenseClassByID(ldla.LicenseClassID);

            License.Application = ldla.Application;
            License.ExpirationDate = DateTime.Now.AddYears(licenseClass.DefaultValidityLength);
            License.IssueDate = DateTime.Now;
            License.CreatedByUserID = clsHelper.user.UserID;
            License.Notes = tbNotes.Text;
            License.IsActive = true;
            License.issueReason = clsLicense.enIssueReason.FirstTime;
            License.DriverID = driverID;
            License.PaidFees = licenseClass.ClassFees;
            License.LicenseClass = ldla.LicenseClassID;

            if (!License.Save())
            {
                MessageBox.Show("Error in saving the new License Record");
                return false;
            }
            ldla.Application.ApplicationStatus = 3;
            ldla.Application.LastStatusDate = DateTime.Now;
            ldla.Application.Save();
            isIssued = true;
            return true;
        }

        private bool _Save()
        {
            clsLocalDrivingLicenseApplication ldla = clsLocalDrivingLicenseApplication.getLocalDrivingLicenseApplicationID(_ldlaID);
            if (ldla == null) return false;
            int driverID = _saveDriver(ldla);
            if (driverID < 0) return false;
            return _saveLicense(ldla, driverID) ;


        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (_Save()) _done();
        }

        private void _done()
        {
            MessageBox.Show("New Driving License Saved Successfully!.");
            btnIssue.Enabled = false;
            btnCancel.Text = "Close";
        }

        private void frmIssueLicense_Load(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication ldla = clsLocalDrivingLicenseApplication.getLocalDrivingLicenseApplicationID(_ldlaID);
            if (ldla == null) return;
            ctrlLocalLincenseApplication1.fillForm(_ldlaID);
            ctrlApplicationInfo1.fillForm(ldla.Application.ApplicationID);
        }
    }
}
