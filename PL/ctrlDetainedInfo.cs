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
    public partial class ctrlDetainedInfo : UserControl
    {
        public ctrlDetainedInfo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public int LicenseID = -1;
        public int DetainID = -1;
        public Decimal Fees = -1;
        clsDetainedLicense dLicense;
        public void RefreshData()
        {
            lblUsername.Text = clsHelper.user.Username;
            lblLicenseID.Text = LicenseID.ToString();
            lblDetainID.Text = DetainID.ToString();
            dLicense = clsDetainedLicense.getDetainedLicenseByLicenseID(LicenseID);
            if(dLicense != null )
            {
                dtp.Value = dLicense.DetainDate;
            }
            if (tbFees.Text.Length > 0 )  Decimal.TryParse(tbFees.Text, out Fees);
            else
            {
                tbFees.Text = Fees.ToString();
                tbFees.Enabled = false;
            }

        }
    }
}
