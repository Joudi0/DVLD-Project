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
    public partial class frmChangePassword : Form
    {
        clsUser user = new clsUser();
        public frmChangePassword(clsUser user)
        {
            InitializeComponent();
            this.user = user;
            ctrlUserInfo1.fillForm(user.UserID);
        }

        private int _tries = 7;

        ErrorProvider errorProvider = new ErrorProvider();

        private bool _validation()
        {
            if ((!clsHelper.isEmpty(tbOldPassword) && !clsHelper.shortPassword(tbOldPassword))
                && (!clsHelper.isEmpty(tbNewPassword) && !clsHelper.shortPassword(tbNewPassword))
                && (!clsHelper.isEmpty(tbNewPasswordAgain) && !clsHelper.shortPassword(tbNewPasswordAgain)))
            {
                return true;
            }
            return false;
        }

        private bool _check()
        {
            if (!_validation()) return false;
            if (tbOldPassword.Text != user.Password)
            {
                _tries -= 1;
                if (_tries == 0)
                {
                    MessageBox.Show($"Invalid Username/Password, you have finished the limit number of tries, please try later.", "Invalid credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return false;
                }
                MessageBox.Show($"Invalid Username/Password, you still have {_tries} try", "Invalid credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (tbNewPassword.Text != tbNewPasswordAgain.Text)
            {
                MessageBox.Show($"You should enter your same new password without deffrint", "not the same password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            user.Password = tbNewPassword.Text;

            if (user.Save())
            {
                if (File.Exists("remember_me.txt"))
                    File.Delete("remember_me.txt");
                MessageBox.Show("Password Changed Successfully!.", "Password has been changed successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_check()) this.Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
