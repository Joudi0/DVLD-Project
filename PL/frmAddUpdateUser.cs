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
    public partial class frmAddUpdateUser : Form
    {
        public frmAddUpdateUser()
        {
            InitializeComponent();
        }

        public void updateMode(int UserID)
        {
            ctrlAddUpdateUser1.FillForm(UserID);
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
        }


        private void _Close()
        {
            this.Close();
        }

        private void ctrlAddUpdateUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
