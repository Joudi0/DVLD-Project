using BLL;
using PL;
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
    public partial class frmLogin : Form
    {
        public bool isLoginSuccess = false;

        private ErrorProvider _errorProvider = new ErrorProvider();

        private int _tries = 3;

        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            _remeberMe();
        }

        private void _remeberMe()
        {
            if (File.Exists("remember_me.txt"))
            {
                if (File.Exists("remember_me.txt"))
                {
                    string data = File.ReadAllText("remember_me.txt");
                    string[] parts = data.Split('#');

                    if (parts.Length == 2)
                    {
                        tbUsername.Text = parts[0];
                        tbPassword.Text = parts[1];
                        chb.Checked = true;
                    }
                }
            }
        }

        private bool _validation()
        {
            if (!clsHelper.isEmpty(tbUsername) && !clsHelper.isEmpty(tbPassword) && !clsHelper.shortPassword(tbPassword))
            {
                return true;
            }
            return false;
        }

        private bool _login()
        {
            clsHelper.user = clsUser.Login(tbUsername.Text, tbPassword.Text);
            if (_validation())
            {
                if (clsHelper.user != null && clsHelper.user.IsActive)
                {
                    return true;
                }
                else
                {
                    _tries -= 1;
                    if (_tries == 0)
                    {
                        MessageBox.Show($"Invalid Username/Password, you have finished the limit number of tries, please try later.", "Invalid credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Application.Exit();
                    }
                    MessageBox.Show($"Invalid Username/Password, you still have {_tries} try", "Invalid credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_login())
            {
                isLoginSuccess = true;
                if (chb.Checked)
                {
                    string data = tbUsername.Text.Trim() + "#" + tbPassword.Text.Trim();
                    File.WriteAllText("remember_me.txt", data);
                }
                else
                {
                    if (File.Exists("remember_me.txt"))
                        File.Delete("remember_me.txt");
                }
                this.Close();
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
