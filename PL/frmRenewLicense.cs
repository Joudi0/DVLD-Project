using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BLL.clsLicense;
namespace PL
{
    public partial class frmRenewLicense : Form
    {
        public frmRenewLicense()
        {
            InitializeComponent();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            _RenewLogic();
        }
        private void _RenewLogic()
        {

            if (ctrlFindLicense1.LicenseID < 1)
            {
                MessageBox.Show("License ID should be >= 1");
                return;
            }
            clsLicense License = clsLicense.getLicenseByID(ctrlFindLicense1.LicenseID);
            if (License == null)
            {
                MessageBox.Show("License Not Found");
                return;
            }
            if (DateTime.Now.AddMonths(6) >= License.ExpirationDate)
            {
                clsApplication App = new clsApplication();
                clsApplicationType appType = clsApplicationType.getApplicationTypeByID(2);
                App.ApplicationStatus = 3; // done
                App.Person = clsDriver.getDriverByID(License.DriverID).Person;
                App.ApplicationTypeID = appType.ApplicationTypeID; // Renew
                App.CreatedByUserID = clsHelper.user.UserID;
                App.PaidFees = appType.ApplicationFees;
                if (!App.Save())
                {
                    MessageBox.Show("Application was not added Seccessfully.");
                    return;
                }
                MessageBox.Show("Application added Seccessfully.");
                ctrlApplicationInfo1.fillForm(App.ApplicationID);

                clsLicense newLicense = new clsLicense();
                newLicense.PaidFees = 20;
                newLicense.Application = App;
                newLicense.DriverID = License.DriverID;
                newLicense.CreatedByUserID = clsHelper.user.UserID;
                newLicense.IsActive = true;
                newLicense.LicenseClass = License.LicenseClass;
                newLicense.issueReason = clsLicense.enIssueReason.ReNew;
                if (!newLicense.Save())
                {
                    MessageBox.Show("License was not renewed successfilly.");
                    return;
                }
                MessageBox.Show("License Renewed successfilly!.");
                License.IsActive = false;
                License.Save();


            }
            else MessageBox.Show("The License Expire Date cannot yet be renewed, come before expiration by 6 months.");

        }
    }
}
