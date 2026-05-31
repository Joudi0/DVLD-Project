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
    public partial class frmShowPersonInfo : Form
    {
        public int PersonID = -1;
        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            this.PersonID = PersonID;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            ctrlPersonInfo1.FillForm(PersonID);
        }

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
