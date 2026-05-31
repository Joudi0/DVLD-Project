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
    public partial class frmDetainLicense : Form
    {
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void llHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicensesHistory frm = new frmLicensesHistory();
            clsDriver Driver = clsDriver.getDriverByID(clsLicense.getLicenseByID(ctrlFindLicense1.LicenseID).DriverID);
            frm.showHistory(Driver.Person.PersonID);
            frm.ShowDialog();
        }


        private void llLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frm = new frmShowLicense(ctrlFindLicense1.LicenseID);
            frm.ShowDialog();

        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {

        }


        private void btnDetain_Click(object sender, EventArgs e)
        {
            _Detain();
        }

        private void _Detain()
        {
            clsLicense License = clsLicense.getLicenseByID(ctrlFindLicense1.LicenseID);
            if(License == null)
            {
                MessageBox.Show("License is not exist");
                return;
            }
            if (!License.IsActive)
            {
                MessageBox.Show("You can only detain the active licenses");
                return;
            }
            clsDetainedLicense dLicense = clsDetainedLicense.getDetainedLicenseByLicenseID(ctrlFindLicense1.LicenseID);
            if (dLicense != null && !dLicense.IsReleased)
            {
                MessageBox.Show("License is already Detained!.");
                return;
            }
          
            dLicense = new clsDetainedLicense();
            dLicense.IsReleased = false;
            dLicense.CreatedByUserID = clsHelper.user.UserID;
            dLicense.LicenseID = ctrlFindLicense1.LicenseID;
            ctrlDetainedInfo1.RefreshData();
            
            dLicense.FineFees = ctrlDetainedInfo1.Fees;
            if(dLicense.Save())
            {
                MessageBox.Show("License Detained Successfully, Detain ID: " + dLicense.DetainID);
                ctrlDetainedInfo1.DetainID = dLicense.DetainID;
                ctrlDetainedInfo1.LicenseID = dLicense.LicenseID;
                ctrlDetainedInfo1.RefreshData();

            }
            else MessageBox.Show("License Detain Failed");

        }
    }
}
