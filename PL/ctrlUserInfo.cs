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
    public partial class ctrlUserInfo : UserControl
    {
        private int _UserID = -1;
        clsUser user = new clsUser();
        public ctrlUserInfo()
        {
            InitializeComponent();

        }

        public void fillForm(int UserID)
        {
            this._UserID = UserID;
            user = clsUser.getUserByID(UserID);
            lblUsername.Text = user.Username;
            lblUserID.Text = user.UserID.ToString();
            if(user.IsActive == true )
            {
                lblState.Text = "Active";
            }
            else lblState.Text = "Not Active";

            ctrlPersonInfo1.FillForm(user.PersonID);
        }

        private void ctrlUserInfo_Load(object sender, EventArgs e)
        {

        }

        private void linklblEditUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_UserID == -1)
            {
                MessageBox.Show("There is no user to edit");
                return;
            }
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.updateMode(_UserID);
            frm.ShowDialog();
        }
    }
}
