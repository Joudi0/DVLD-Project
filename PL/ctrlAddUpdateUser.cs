using BLL;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ctrlAddUpdateUser : UserControl
    {
        public ctrlAddUpdateUser()
        {
            InitializeComponent();
        }

        enum enMode { AddNew = 0, Update = 1 };
        enMode mode = enMode.AddNew;

        private void ctrlAddUpdateUser_Load(object sender, EventArgs e)
        {

        }

        ErrorProvider errorProvider = new ErrorProvider();


        private clsUser _User = new clsUser();

        public void FillForm(int UserID)
        {
            clsUser User = clsUser.getUserByID(UserID);
            if (User != null)
            {
                tbUsername.Text = User.Username;
                chbIsActive.Checked = User.IsActive;
                lblTitle.Text = "Update User";
                button1.Text = "update";
                mode = enMode.Update;
                linklblChangePassword.Visible = true;
                tbPassword.Visible = false;
                tbPasswordConfirm.Visible = false;
                ctrlPersonInfoFilter1.fillForm(User.PersonID);
                _User = User;
            }
        }

        private void tpUser_Click(object sender, EventArgs e)
        {

        }

        private void tpPerson_Click(object sender, EventArgs e)
        {

        }

        private bool _checkAdd()
        {
            bool isCorrect = true;
            if (clsHelper.isEmpty(tbUsername)) isCorrect = false;

            else if (clsUser.isExistsByUsername(tbUsername.Text))
            {
                errorProvider.SetError(tbUsername, "This username is already taken");
                isCorrect = false;
            }
            else if (clsHelper.isEmpty(tbPassword)) isCorrect = false;
            else if (clsHelper.isEmpty(tbPasswordConfirm)) isCorrect = false;
            else if (tbPassword.Text != tbPasswordConfirm.Text)
            {
                MessageBox.Show("You should write the same password with no deffrints");
                isCorrect = false;
            }
            else if (tbPassword.Text.Length < 4)
            {
                errorProvider.SetError(tbPassword, "Your Password should be no less than 4 characters.");
                isCorrect = false;
            }

            return isCorrect;
        }

        private bool _checkUpdate()
        {
            bool isCorrect = true;
            if (clsHelper.isEmpty(tbUsername)) isCorrect = false;

            else if (clsUser.isExistsByUsername(tbUsername.Text) && _User.Username != tbUsername.Text)
            {
                errorProvider.SetError(tbUsername, "This username is already taken");
                isCorrect = false;
            }
            return isCorrect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mode == enMode.AddNew && _checkAdd())
            {
                _add();
            }
            else if (mode == enMode.Update && _checkUpdate())
            {
                _update();
            }
        }

        private void _add()
        {
            clsUser User = new clsUser();
            User.Username = tbUsername.Text;
            User.Password = tbPassword.Text;
            User.IsActive = chbIsActive.Checked;
            User.PersonID = ctrlPersonInfoFilter1.PersonID;
            if (User.Save())
            {
                MessageBox.Show("User Saved Successfully!.");
                _User = User;
                FillForm(User.UserID);
                mode = enMode.Update;
                linklblChangePassword.Visible = true;
                tbPassword.Visible = false;
                tbPasswordConfirm.Visible = false;
            }
            else
            {
                MessageBox.Show("User Creation Failed.");

            }
        }

        private void _update()
        {
            if (_User.UserID != clsHelper.user.UserID) _User.IsActive = chbIsActive.Checked;
            else
            {
                chbIsActive.Checked = true;
                MessageBox.Show("You cannot deactive your own account");
            }
            if (!(clsHelper.isEmpty(tbUsername)))
            {
                _User.Username = tbUsername.Text;
            }
            if (ctrlPersonInfoFilter1.PersonID != -1)
            {
                clsPerson Person = clsPerson.getPersonByID(ctrlPersonInfoFilter1.PersonID);
                _User.PersonID = Person.PersonID;
                MessageBox.Show("Hello! " + _User.PersonID);

            }
            if (_User.Save())
            {
                MessageBox.Show("User Updated Successfully!.");
                mode = enMode.Update;

                FillForm(_User.UserID);
            }
            else
            {
                MessageBox.Show("User Update Failed.");

            }

        }

        private void linklblChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(_User);
            frm.ShowDialog();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            int PersonID = frm.PersonID;
            if(PersonID != -1) ctrlPersonInfoFilter1.fillForm(PersonID);

        }
    }
}
