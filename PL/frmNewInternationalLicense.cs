using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using BLL;
namespace PL
{
    public partial class frmNewInternationalLicense : Form
    {
        public frmNewInternationalLicense()
        {
            InitializeComponent();
        }
        private void frmNewInternationalLicense_Load(object sender, EventArgs e)
        {

        }

        private void btnIssue_Click_1(object sender, EventArgs e)
        {
            internationalLicenseLogic();
        }

        private void internationalLicenseLogic()
        {
            clsLicense License = clsLicense.getLicenseByID(ctrlFindLicense1.LicenseID);
            if (License == null)
            {
                MessageBox.Show("There is no local License");
                return;
            }

            if (clsInternationalLicense.isInternationalLicenseExistByDriverID(License.DriverID))
            {
                MessageBox.Show("The Driver have International License Already");
                return;
            }
            else if (!License.IsActive)
            {
                MessageBox.Show("License Should be Active");
                return;
            }
            else if (License.LicenseClass != 3)
            {
                MessageBox.Show("License Class Should Be Ordery Vihcles (3) ");
                return;
            }
            else
            {
                clsApplication App = new clsApplication();
                App.ApplicationTypeID = 6; // International License
                App.PaidFees = 51;
                App.ApplicationStatus = 3; // Done
                App.Person = clsDriver.getDriverByID(License.DriverID).Person;
                App.CreatedByUserID = clsHelper.user.UserID;
                if (App.Save())
                {
                    MessageBox.Show("Application Added Seccessfully");
                    clsInternationalLicense internationalLicense = new clsInternationalLicense();
                    internationalLicense.ApplicationID = App.ApplicationID;
                    internationalLicense.IssuedUsingLocalLicenseID = License.LicenseID;
                    internationalLicense.DriverID = License.DriverID;
                    internationalLicense.CreatedByUserID = clsHelper.user.UserID;
                    internationalLicense.IsActive = true;
                    if (internationalLicense.Save())
                    {
                        MessageBox.Show("international License Issued Successfully, ID: " + internationalLicense.InternationalLicenseID);
                        ctrlInternationalApplicationInfo1.fillForm(internationalLicense.InternationalLicenseID);
                        llShowiLicense.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("international License Was not Issued because of Error");
                    }
                }

            }


        }

        private void llHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicensesHistory frm = new frmLicensesHistory();
            frm.showHistory(clsDriver.getDriverByID(clsLicense.getLicenseByID(ctrlFindLicense1.LicenseID).DriverID).Person.PersonID);
            frm.ShowDialog();
        }

        private void llShowiLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicense frm = new frmShowInternationalLicense();
            frm.fillForm(ctrlFindLicense1.LicenseID);
            frm.ShowDialog();
        }
    }
}
