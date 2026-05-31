using BLL;
using PL;
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
    public partial class frmManageLocalLicenseApplications : Form
    {
        public frmManageLocalLicenseApplications()
        {
            InitializeComponent();
        }
        DataTable _dt = clsLocalDrivingLicenseApplication.getAllView();
        DataView _dv = new DataView();

        private void _refreshData()
        {
            _dt = clsLocalDrivingLicenseApplication.getAllView();
            lblRecords.Text = $"# Records: {_dt.Rows.Count}";
        }

        private void _refreshDataView()
        {
            _dt = clsLocalDrivingLicenseApplication.getAllView();
            _dv = _dt.DefaultView;
            dgv.DataSource = _dv;

        }

        private void _refresh()
        {
            _refreshData();
            _refreshDataView();
        }

        private void frmManageLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            _refresh();
            if (dgv.Columns.Contains("FullName"))
            {
                dgv.Columns["FullName"].Width = 300;
            }
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            if (dgv.Columns.Contains("FullName"))
                dgv.Columns["FullName"].Width = 300;
            if (dgv.Columns.Contains("ApplicationDate"))
                dgv.Columns["ApplicationDate"].Width = 150;
            if (dgv.Columns.Contains("ClassName"))
                dgv.Columns["ClassName"].Width = 250;
            cb.Items.Clear();

            cb.Items.Add(new { Text = "None", Value = "None" });
            cb.Items.Add(new { Text = "Local License Application ID", Value = "LocalDrivingLicenseApplicationID_Numeric" });
            cb.Items.Add(new { Text = "National Number", Value = "NationalNo_Mixed" });
            cb.Items.Add(new { Text = "FullName", Value = "FullName_Alpha" });
            cb.Items.Add(new { Text = "Status", Value = "Status" });

            cb.DisplayMember = "Text";
            cb.ValueMember = "Value";
            cb.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewDrivingLicense frm = new frmNewDrivingLicense();
            frm.ShowDialog();
            _refreshDataView();
        }

        private void _showFilter()
        {
            if (cb.SelectedIndex < 1 || cb.SelectedItem == null)
            {
                tbFilter.Visible = false;

                _dv.RowFilter = "";
                return;
            }

            string selectedValue = ((dynamic)cb.SelectedItem).Value;

            if (selectedValue == "Status")
            {
                tbFilter.Visible = false;
                cbStatus.Visible = true;
            }
            else
            {
                tbFilter.Visible = true;
                cbStatus.Visible = false;

            }

            tbFilter.Text = "";
            tbFilter.Focus();
        }

        private void _filter()
        {
            if (cb.SelectedItem == null) return;
            if (cb.SelectedIndex < 1 || string.IsNullOrWhiteSpace(tbFilter.Text))
            {
                _dv.RowFilter = "";

                return;
            }

            string selectedValue = ((dynamic)cb.SelectedItem).Value;
            string columnName = selectedValue.Split('_')[0];
            string mode = selectedValue.Split('_')[1];

            if (!clsHelper.ValidateInput(tbFilter, mode))
            {
                return;
            }

            if (mode == "Numeric") _dv.RowFilter = $"[{columnName}] = {tbFilter.Text.Trim()}";
            else _dv.RowFilter = $"[{columnName}] LIKE '{tbFilter.Text.Trim()}%'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {

            _filter();
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cb.SelectedItem != null)
            {
                string mode = ((dynamic)cb.SelectedItem).Value.Split('_')[1];

                clsHelper.SmartKeyPress(e, mode);
            }
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _showFilter();
        }



        private void _filterStatus()
        {
            if (cbStatus.SelectedItem != null) _dv.RowFilter = $"[Status] = '{cbStatus.SelectedItem.ToString()}%'";
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filterStatus();

        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Index == -1 || dgv.CurrentRow.Cells[0].Value == DBNull.Value)
                return;

            int passedTests = Convert.ToInt32(dgv.CurrentRow.Cells[5].Value);

            var menuSchedule = cms.Items.Find("sheudleToolStripMenuItem", true).FirstOrDefault();
            var itemVision = cms.Items.Find("visionTestToolStripMenuItem", true).FirstOrDefault();
            var itemWritten = cms.Items.Find("WrittinTestToolStripMenuItem", true).FirstOrDefault();
            var itemStreet = cms.Items.Find("StreetTestToolStripMenuItem", true).FirstOrDefault();
            var issueLicense = cms.Items.Find("issueDrivingLicenseFirstTimeToolStripMenuItem", true).FirstOrDefault();
            var showLicense = cms.Items.Find("showLicenseToolStripMenuItem", true).FirstOrDefault();
            var CancelLicense = cms.Items.Find("cancelApplicationToolStripMenuItem", true).FirstOrDefault();
            var DeleteLicense = cms.Items.Find("deleteToolStripMenuItem", true).FirstOrDefault();
            var UpdateLicense = cms.Items.Find("updateToolStripMenuItem", true).FirstOrDefault();
            string status = dgv.CurrentRow.Cells["Status"].Value.ToString();

            if (menuSchedule != null) menuSchedule.Enabled = (passedTests != 3);
            if (itemVision != null) itemVision.Enabled = (passedTests == 0);
            if (itemWritten != null) itemWritten.Enabled = (passedTests == 1);
            if (itemStreet != null) itemStreet.Enabled = (passedTests == 2);

            if (issueLicense != null) issueLicense.Enabled = (passedTests == 3 && status == "New");
            if (showLicense != null) showLicense.Enabled = status == "Completed";
            if (CancelLicense != null) CancelLicense.Enabled = status == "New";
            if (DeleteLicense != null) DeleteLicense.Enabled = status != "Completed";
            if (UpdateLicense != null) UpdateLicense.Enabled = status == "New";
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Index == -1 || dgv.CurrentRow.Cells[0].Value == DBNull.Value)
                return;
            int lappID = (int)dgv.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication licenseApplication = clsLocalDrivingLicenseApplication.getLocalDrivingLicenseApplicationID(lappID);
            frmApplicationInfo frm = new frmApplicationInfo(licenseApplication.Application.ApplicationID);
            frm.ShowDialog();
        }

        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _showTestManagement(1);
            _refresh();

        }

        private void writtinTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _showTestManagement(2);
            _refresh();

        }

        private void streetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _showTestManagement(3);
            _refresh();
        }

        private void _showTestManagement(int testTypeID)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Index == -1 || dgv.CurrentRow.Cells[0].Value == DBNull.Value)
                return;
            int lappID = (int)dgv.CurrentRow.Cells[0].Value;
            frmTestManagement frm = new frmTestManagement(lappID, testTypeID);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Index == -1 || dgv.CurrentRow.Cells[0].Value == DBNull.Value)
                return;
            int lappID = (int)dgv.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete this application? All associated appointments and tests will be permanently deleted.", "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsLocalDrivingLicenseApplication.deleteLocalDrivingLicenseApplication(lappID))
                {
                    MessageBox.Show("Application Deleted Successfully!.");
                    _refresh();

                }
                else
                {
                    MessageBox.Show("Application Delete Failed.");

                }

            }

        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgv.CurrentRow == null || dgv.CurrentRow.Index == -1 || dgv.CurrentRow.Cells[0].Value == DBNull.Value)
                return;
            MessageBox.Show("Warning, if this application is done with a license, the license will be canseled too/unactivate");
            int lappID = (int)dgv.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication app = clsLocalDrivingLicenseApplication.getLocalDrivingLicenseApplicationID(lappID);
            app.Application.ApplicationStatus = 2;
            app.Application.LastStatusDate = DateTime.Now;
            clsDriver Driver = clsDriver.getDriverByPersonID(app.Application.Person.PersonID);
            if (Driver != null)
            {
                clsLicense license = clsLicense.getLicenseByDriverAndClassID(Driver.DriverID, app.LicenseClassID);
                if (license != null)
                {
                    license.IsActive = false;
                    license.Save();
                }
            }

            if (app.Save())
            {
                MessageBox.Show("Application Canceled Successfully!.");
                _refresh();
            }
            else
            {
                MessageBox.Show("Application Cancel Failed.");

            }
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cms.Items.Find("sheudleToolStripMenuItem", true).FirstOrDefault() != null)
            {
                if (cms.Items.Find("sheudleToolStripMenuItem", true).FirstOrDefault().Enabled)
                {
                    return;
                }
            }
            if (dgv.CurrentRow == null || dgv.CurrentRow.Index == -1 || dgv.CurrentRow.Cells[0].Value == DBNull.Value)
                return;
            int lappID = (int)dgv.CurrentRow.Cells[0].Value;

            frmIssueLicense frm = new frmIssueLicense(lappID);
            frm.ShowDialog();
            _refresh();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Index == -1 || dgv.CurrentRow.Cells[0].Value == DBNull.Value)
                return;
            int lappID = (int)dgv.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication ldla = clsLocalDrivingLicenseApplication.getLocalDrivingLicenseApplicationID(lappID);
            if (ldla != null)
            {
                clsDriver Driver = clsDriver.getDriverByPersonID(ldla.Application.Person.PersonID);
                if (Driver != null)
                {
                    frmShowLicense frm = new frmShowLicense(clsLicense.getLicenseByDriverAndClassID(Driver.DriverID, ldla.LicenseClassID).LicenseID);
                    frm.ShowDialog();
                }
            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Index == -1 || dgv.CurrentRow.Cells[0].Value == DBNull.Value)
                return;
            int lappID = (int)dgv.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication ldla = clsLocalDrivingLicenseApplication.getLocalDrivingLicenseApplicationID(lappID);
            if (ldla != null)
            {
                clsDriver Driver = clsDriver.getDriverByPersonID(ldla.Application.Person.PersonID);
                if (Driver != null)
                {
                    frmLicensesHistory frm = new frmLicensesHistory();
                    frm.showHistory(ldla.Application.Person.PersonID);
                    frm.ShowDialog();
                }
            }

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
