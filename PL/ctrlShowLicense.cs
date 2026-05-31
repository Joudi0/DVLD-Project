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
    public partial class ctrlShowLicense : UserControl
    {
        public ctrlShowLicense()
        {
            InitializeComponent();
        }

        public void fillForm(int licenseID)
        {
            clsLicense license = clsLicense.getLicenseByID(licenseID);
            if (license == null)
            {
                MessageBox.Show("License not Found");
                return;
            }
            lblID.Text = license.LicenseID.ToString();
            clsLicenseClass licenseClass = clsLicenseClass.getLicenseClassByID(license.LicenseClass);
            if (licenseClass == null)
            {
                lblLicenseClass.Text = "Not Found";
            }
            else lblLicenseClass.Text = licenseClass.ClassName;
            lblName.Text = license.Application.Person.getFullName();
            lblNN.Text = license.Application.Person.NationalNumber;
            if (license.Application.Person.Gender == 0) lblGender.Text = "Male";
            else lblGender.Text = "Female";
            lblDriverID.Text = license.DriverID.ToString();
            if (license.IsActive) lblIsActive.Text = "Active";
            else lblIsActive.Text = "Not Active";
            dtpDateOfBirth.Value = license.Application.Person.DateOfBirth;
            dtpExpireDate.Value = license.ExpirationDate;
            lblNotes.Text = license.Notes;
            lblReason.Text = license.getIssueReason();
            dtpIssueDate.Value = license.IssueDate;
            lblIsDetained.Text = "No"; // clsDetainedLicense.isDetainedByLicenseID(license.licenseID) ? "Yes" : No;
            if (!string.IsNullOrEmpty(license.Application.Person.ImagePath) && System.IO.File.Exists(clsHelper.imagesFolder + license.Application.Person.ImagePath))
            {
                pbImage.ImageLocation = clsHelper.imagesFolder + license.Application.Person.ImagePath;
            }
            else
            {
                pbImage.ImageLocation = null;
                pbImage.Image = (license.Application.Person.Gender == 0) ? Resources.person_man : Resources.person_woman;
            }
        }
        private void ctrlShowLicense_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
