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
    public partial class frmManageDetainedLicenses : Form
    {
        public frmManageDetainedLicenses()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
            _Refresh();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
            _Refresh();
        }

        private void showPersonDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                int selectedLicenseID = (int)dgv.CurrentRow.Cells["LicenseID"].Value;
                clsDriver Driver = clsDriver.getDriverByID(clsLicense.getLicenseByID(selectedLicenseID).DriverID);

                frmShowPersonInfo frm = new frmShowPersonInfo(Driver.Person.PersonID);
                frm.ShowDialog();
            }

        }

        private void showLicenseDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                int selectedLicenseID = (int)dgv.CurrentRow.Cells["LicenseID"].Value;

                frmShowLicense frm = new frmShowLicense(selectedLicenseID);
                frm.ShowDialog();
            }
        }

        private void showLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                int selectedLicenseID = (int)dgv.CurrentRow.Cells["LicenseID"].Value;
                clsDriver Driver = clsDriver.getDriverByID(clsLicense.getLicenseByID(selectedLicenseID).DriverID);

                frmLicensesHistory frm = new frmLicensesHistory();
                frm.showHistory(Driver.Person.PersonID);
                frm.ShowDialog();
            }
        }

        private void dgv_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            dgv.ClearSelection();
            dgv.Rows[e.RowIndex].Selected = true;
            dgv.CurrentCell = dgv.Rows[e.RowIndex].Cells[0];
            if (dgv.CurrentRow != null)
            {
                bool isReleased = (bool)dgv.CurrentRow.Cells["IsReleased"].Value;
                if (isReleased)
                {
                    releaseToolStripMenuItem.Enabled = false;
                }
                else
                {
                    releaseToolStripMenuItem.Enabled = true;
                }
            }
        }
        DataTable dt = clsDetainedLicense.getAll();
        DataView dv;
        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            lblRecords.Text = dt.Rows.Count.ToString();
            dgv.DataSource = dv;

        }
        private void _Refresh()
        {
            DataTable dt = clsDetainedLicense.getAll();
            DataView dv = dt.DefaultView;
            dgv.DataSource = dv;
        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                int selectedLicenseID = (int)dgv.CurrentRow.Cells["DetainID"].Value;
                frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense(selectedLicenseID);
                frm.ShowDialog();
            }
            
            
        }
    }
}
