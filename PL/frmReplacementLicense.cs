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

namespace PL
{
    public partial class frmReplacementLicense : Form
    {
        public frmReplacementLicense()
        {
            InitializeComponent();
        }

        private void frmReplacementLicense_Load(object sender, EventArgs e)
        {

        }

        private bool _ReplaceCheck(clsLicense License)
        {
            if (ctrlFindLicense1.LicenseID < 1)
            {
                MessageBox.Show("License ID should be >= 1");
                return false;
            }
            if (License == null)
            {
                MessageBox.Show("License Not Found");
                return false;
            }
            if (!(rbDamaged.Checked || rbLost.Checked))
            {
                MessageBox.Show("You should choose the category");
                return false;
            }
            if (!License.IsActive)
            {
                MessageBox.Show("License Should be active to replace");
                return false;
            }
            return true;
        }

        private void _ReplacementLogic()
        {
            clsLicense License = clsLicense.getLicenseByID(ctrlFindLicense1.LicenseID);

            if (!_ReplaceCheck(License)) return;
            clsApplication App = new clsApplication();

            if (rbLost.Checked)
            {
                clsApplicationType appType = clsApplicationType.getApplicationTypeByID(3);
                App.ApplicationTypeID = appType.ApplicationTypeID; // Lost
                App.PaidFees = appType.ApplicationFees;
            }
            else
            {
                clsApplicationType appType = clsApplicationType.getApplicationTypeByID(4);
                App.ApplicationTypeID = appType.ApplicationTypeID; // Damaged
                App.PaidFees = appType.ApplicationFees;
            }

            App.ApplicationStatus = 3; // done
            App.Person = clsDriver.getDriverByID(License.DriverID).Person;

            App.CreatedByUserID = clsHelper.user.UserID;
            if (!App.Save())
            {
                MessageBox.Show("Application was not added Successfully.");
                return;
            }
            MessageBox.Show("Application added Successfully.");

            ctrlApplicationInfo1.fillForm(App.ApplicationID);
            clsLicense newLicense = new clsLicense();
            newLicense.PaidFees = 20;
            newLicense.Application = App;
            newLicense.DriverID = License.DriverID;
            newLicense.CreatedByUserID = clsHelper.user.UserID;
            newLicense.IsActive = true;
            newLicense.IssueDate = DateTime.Now;
            newLicense.ExpirationDate = License.ExpirationDate;
            newLicense.LicenseClass = License.LicenseClass;
            newLicense.issueReason = clsLicense.enIssueReason.Repleacement;


            if (!newLicense.Save())
            {
                MessageBox.Show("License was not Replaced Successfully in the system.");
                return;
            }
            MessageBox.Show("License Replaced Successfully!.");
            License.IsActive = false;
            License.Save();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            _ReplacementLogic();
        }
    }
}
