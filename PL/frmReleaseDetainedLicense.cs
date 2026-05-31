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
    public partial class frmReleaseDetainedLicense : Form
    {
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }
        public frmReleaseDetainedLicense(int dLicenseID)
        {
            InitializeComponent();
            clsDetainedLicense dLisense = clsDetainedLicense.getDetainedLicenseByID(dLicenseID);
            ctrlFindLicense1.Search(dLisense.LicenseID);
            ctrlDetainedInfo1.LicenseID = ctrlFindLicense1.LicenseID;
            ctrlDetainedInfo1.DetainID = dLisense.DetainID;
            ctrlDetainedInfo1.Fees = dLisense.FineFees;
            ctrlDetainedInfo1.RefreshData();
            ctrlFindLicense1.Enabled = false;

        }
        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {

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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(clsDetainedLicense.isDetainedLicenseExistByLicenseID(ctrlFindLicense1.LicenseID))
            {
                btnRelease.Enabled = true;
                MessageBox.Show("It is Detained, you can Release.");

            }
            else
            {
                MessageBox.Show("This License in not Detained");
                btnRelease.Enabled = false;

            }
        }

        private void _Release()
        {
            ctrlDetainedInfo1.LicenseID = ctrlFindLicense1.LicenseID;
            clsDetainedLicense dLicense = clsDetainedLicense.getDetainedLicenseByLicenseID(ctrlFindLicense1.LicenseID);
            if (dLicense != null)
            {
                ctrlDetainedInfo1.DetainID = dLicense.DetainID;
                clsApplication App = new clsApplication();
                clsApplicationType AppType = clsApplicationType.getApplicationTypeByID(5); // release
                App.ApplicationStatus = 2; // done
                App.PaidFees = AppType.ApplicationFees;
                lblApplicationFees.Text = AppType.ApplicationFees.ToString();
                App.ApplicationDate = DateTime.Now;
                App.CreatedByUserID = clsHelper.user.UserID;
                App.ApplicationTypeID = AppType.ApplicationTypeID;
                App.Person = clsDriver.getDriverByID(clsLicense.getLicenseByID(ctrlFindLicense1.LicenseID).DriverID).Person;
                if (App.Save())
                {
                    MessageBox.Show("Application Saved Successfully!.");
                    dLicense.IsReleased = true;
                    dLicense.ReleaseApplicationID = App.ApplicationID;
                    dLicense.ReleasedByUserID = clsHelper.user.UserID;
                    ctrlDetainedInfo1.Fees = dLicense.FineFees;
                    ctrlDetainedInfo1.RefreshData();
                    if (dLicense.Save())
                    {
                        MessageBox.Show("License Released Successfully!.");

                    }
                    else
                    {
                        MessageBox.Show("License Releasing Failed.");

                    }
                }
                else
                {
                    MessageBox.Show("Application Saving Failed.");
                    return;

                }

                return;
            }
            else
            {
                MessageBox.Show("Error: This License in not Detained");

            }
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            _Release();
        }
    }
}
