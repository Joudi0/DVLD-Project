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
    public partial class frmApplicationInfo : Form
    {
        public frmApplicationInfo(int appID)
        {
            InitializeComponent();
            ctrlApplicationInfo1.fillForm(appID);
        }

        private void ctrlApplicationInfo1_Load(object sender, EventArgs e)
        {

        }

        private void frmApplicationInfo_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
        }
    }
}
