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
    public partial class ctrlLicenseHistory : UserControl
    {
        public ctrlLicenseHistory()
        {
            InitializeComponent();
        }

        private void ctrlLicenseHistory_Load(object sender, EventArgs e)
        {

        }

        public void loadDGVs(int PersonID)
        {
            clsDriver Driver = clsDriver.getDriverByPersonID(PersonID);
            if( Driver != null )
            {
                DataTable dtLicenses = clsLicense.getAllWithDriverID(Driver.DriverID);
                dgvLocal.DataSource = dtLicenses;
                lblLocalRecords.Text = "# Records: " + dtLicenses.Rows.Count.ToString();
                DataTable dtInternationalLicenses = clsInternationalLicense.getAllByDriverID(Driver.DriverID);
                dgvInternational.DataSource = dtInternationalLicenses;
                lblInternationalRecords.Text = "# Records: " + dtInternationalLicenses.Rows.Count.ToString();
            }
        }

        private void dgvLocal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
