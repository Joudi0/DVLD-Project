using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class frmManageInternationalApplications : Form
    {
        public frmManageInternationalApplications()
        {
            InitializeComponent();
        }

        private void frmManageInternationalApplications_Load(object sender, EventArgs e)
        {
            loadDGVs();
        }
        public void loadDGVs()
        {
            DataTable dtLicenses = clsInternationalLicense.getAll();
            dgvInternational.DataSource = dtLicenses;
            lblRecords.Text = "# Records: " + dtLicenses.Rows.Count.ToString();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInternational.CurrentRow != null)
            {
                int recordID = (int)dgvInternational.CurrentRow.Cells["DriverID"].Value;
                clsDriver Driver = clsDriver.getDriverByID(recordID);
                frmShowPersonInfo frm = new frmShowPersonInfo(Driver.Person.PersonID);
                frm.ShowDialog();
            }
                
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInternational.CurrentRow != null)
            {
                int recordID = (int)dgvInternational.CurrentRow.Cells["DriverID"].Value;
                clsDriver Driver = clsDriver.getDriverByID(recordID);
                
                frmShowInternationalLicense frm = new frmShowInternationalLicense();
                frm.fillForm(clsLicense.getLicenseByDriverAndClassID(Driver.DriverID, 3).LicenseID);
                frm.ShowDialog();
            }
           
        }

        private void showInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInternational.CurrentRow != null)
            {
                int recordID = (int)dgvInternational.CurrentRow.Cells["DriverID"].Value;
                clsDriver Driver = clsDriver.getDriverByID(recordID);

                frmLicensesHistory frm = new frmLicensesHistory();
                frm.showHistory(Driver.Person.PersonID);
                frm.ShowDialog();
            }
        }
    }
}
