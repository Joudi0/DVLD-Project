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
    public partial class frmUserInfo : Form
    {
        private int _UserID = -1;
        public frmUserInfo()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
        }

        public frmUserInfo(int userID)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            this._UserID = userID;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            if(_UserID == -1) ctrlUserInfo1.fillForm(clsHelper.user.UserID);
            else ctrlUserInfo1.fillForm(this._UserID);
        }
    }
}
