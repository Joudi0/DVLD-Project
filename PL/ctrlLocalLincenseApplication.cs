using BLL;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PL
{
    public partial class ctrlLocalLincenseApplication : UserControl
    {
        public ctrlLocalLincenseApplication()
        {
            InitializeComponent();
        }

        private void ctrlLocalLincenseApplication_Load(object sender, EventArgs e)
        {

        }
        clsLocalDrivingLicenseApplication localLicenseApp = new clsLocalDrivingLicenseApplication();

        public void fillForm(int appID)
        {
            localLicenseApp = clsLocalDrivingLicenseApplication.getLocalDrivingLicenseApplicationID(appID);
            lblID.Text = appID.ToString();
            clsLicenseClass lClass = clsLicenseClass.getLicenseClassByID(localLicenseApp.LicenseClassID);
            lblLicenseClass.Text = lClass.ClassName;
            lblExams.Text = clsLocalDrivingLicenseApplication.examsPassedByID(appID).ToString();


        }
    }
}
