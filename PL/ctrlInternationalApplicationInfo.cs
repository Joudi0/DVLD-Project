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
    public partial class ctrlInternationalApplicationInfo : UserControl
    {
        public ctrlInternationalApplicationInfo()
        {
            InitializeComponent();
        }

        private void ctrlInternationalApplicationInfo_Load(object sender, EventArgs e)
        {


        }

        public void fillForm(int InternationalLicenseID)
        {
            clsInternationalLicense internationalLicense = clsInternationalLicense.getInternationalLicenseByID(InternationalLicenseID);

            lblInternationalLicenseID.Text = internationalLicense.InternationalLicenseID.ToString();
            lblAppID.Text = internationalLicense.ApplicationID.ToString();
        }
    }
}
