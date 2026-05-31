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
    public partial class frmLicensesHistory : Form
    {
        public frmLicensesHistory()
        {
            InitializeComponent();
        }

        private void frmLicensesHistory_Load(object sender, EventArgs e)
        {

        }

        public void showHistory(int PersonID)
        {
            ctrlPersonInfo1.FillForm(PersonID);
            ctrlLicenseHistory1.loadDGVs(PersonID);
        }
    }
}
