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
    public partial class ctrlApplicationInfo : UserControl
    {
        public ctrlApplicationInfo()
        {
            InitializeComponent();
        }
        clsApplication Application = new clsApplication();
        private void ctrlApplicationInfo_Load(object sender, EventArgs e)
        {

        }

        public void fillForm(int appID)
        {
            Application = clsApplication.getApplicationbyApplicationID(appID);
            lblID.Text = appID.ToString();
            clsApplicationType type = clsApplicationType.getApplicationTypeByID(Application.ApplicationTypeID);
            lblType.Text = type.ApplicationTypeTitle;
            if (Application.ApplicationStatus == 1) lblStatus.Text = "New";
            if (Application.ApplicationStatus == 2) lblStatus.Text = "Canceled";
            if (Application.ApplicationStatus == 3) lblStatus.Text = "Completed";
            lblFees.Text = ((int)Application.PaidFees).ToString() + "$";
            lblFullName.Text = Application.Person.getFullName();
            lblUsername.Text = clsHelper.user.Username;
            dtpStatus.Value = Application.LastStatusDate;
            dtpDate.Value = Application.ApplicationDate;
        }

        private void linklblPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(Application.Person.PersonID);
            frm.ShowDialog();
        }

        private void gpInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
