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
    public partial class frmShowInternationalLicense : Form
    {
        public frmShowInternationalLicense()
        {
            InitializeComponent();
        }

        private void frmShowInternationalLicense_Load(object sender, EventArgs e)
        {

        }

        public void fillForm(int LicenseID)
        {
            ctrlShowLicense1.fillForm(LicenseID);
            clsDriver Driver = clsDriver.getDriverByID(clsLicense.getLicenseByID(LicenseID).DriverID);
            ctrlInternationalApplicationInfo1.fillForm(clsInternationalLicense.getInternationalLicenseByDriverID(Driver.DriverID).InternationalLicenseID);
        }
    }
}
