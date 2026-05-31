using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PL
{
    public partial class frmTestManagement : Form
    {
        public frmTestManagement(int ldla, int testTypeID)
        {
            InitializeComponent();
            _ldla = ldla;
            _testTypeID = testTypeID;
        }
        public frmTestManagement()
        {
            InitializeComponent();
        }
        DataTable _dt = new DataTable();
        DataView _dv = new DataView();
        int _ldla = -1;
        int _testTypeID = -1;
        string _testType = "";

        private void _refresh()
        {
            _dt = clsTestAppointment.getAll();
            _dv = _dt.DefaultView;
            _dv.RowFilter = $"LocalDrivingLicenseApplicationID = {_ldla} AND TestTypeTitle = '{_testType}'";
            dgv.DataSource = _dv;
        }

        private void frmVisionTest_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            clsTestType testType = clsTestType.getTestTypeByID(_testTypeID);
            _testType = testType.TestTypeTitle;
            _dv.RowFilter = $"LocalDrivingLicenseApplicationID = {_ldla} AND TestTypeTitle = '{testType.TestTypeTitle}'";
            dgv.DataSource = _dv;
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.getLocalDrivingLicenseApplicationID(_ldla);
            ctrlLocalLincenseApplication1.fillForm(localDrivingLicenseApplication.LocalDrivingLicenseApplicationID);
            ctrlApplicationInfo1.fillForm(localDrivingLicenseApplication.Application.ApplicationID);
            _chooseImage(_testTypeID);
            _refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool _hasActiveAppointment()
        {
            foreach (DataRowView row in _dv)
            {
                if (!(bool)row["IsLocked"])
                {
                    return true;
                }
            }
            return false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _Add();
            _refresh();
        }

        private void _Add()
        {
            if (_ldla == -1 || _testTypeID == -1)
            {

                MessageBox.Show("Error: ldlaID or testTypeID not found");
                return;
            }
            if (!_hasActiveAppointment())
            {
                clsLocalDrivingLicenseApplication clsLocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.getLocalDrivingLicenseApplicationID(_ldla);
                if (!_notFinishedYet())
                {
                    MessageBox.Show("Error: You cannot add new test appointment because you already have p.assed the test");
                }
                else
                {
                    frmAddTestAppointment frm = new frmAddTestAppointment(_ldla, _testTypeID);
                    frm.ShowDialog();
                    _refresh();
                }

            }
            else
            {
                MessageBox.Show("Error: You cannot add new test appointment because you already have an active one.");

            }
        }
        private bool _notFinishedYet()
        {
            switch (_testTypeID)
            {
                case 1: return clsLocalDrivingLicenseApplication.examsPassedByID(_ldla) == 0;
                case 2: return clsLocalDrivingLicenseApplication.examsPassedByID(_ldla) == 1;
                case 3: return clsLocalDrivingLicenseApplication.examsPassedByID(_ldla) == 2;
                default: return false;
            }
        }
        private void _chooseImage(int TestTypeID)
        {

            switch (TestTypeID)
            {
                case 1:
                    pbTestImage.Image = Resources.Vision_512;
                    lblTitle.Text = "Vision Test";
                    break;
                case 2:
                    pbTestImage.Image = Resources.Written_Test_512;
                    lblTitle.Text = "Written Test";
                    break;
                case 3:
                    pbTestImage.Image = Resources.Local_Driving_License_512;
                    lblTitle.Text = "Street Test";

                    break;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow.Cells[0].Value == null || dgv.CurrentRow.Cells[0] == null) return;
            int SelectedTestAppointmentID = (int)dgv.CurrentRow.Cells[0].Value;
            frmAddTestAppointment frm = new frmAddTestAppointment(_ldla, _testTypeID, SelectedTestAppointmentID);
            frm.ShowDialog();
            _refresh();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow.Cells[0].Value == null || dgv.CurrentRow.Cells[0] == null) return;
            int SelectedTestAppointmentID = (int)dgv.CurrentRow.Cells[0].Value;
            frmTakeTest frm = new frmTakeTest(SelectedTestAppointmentID);
            frm.ShowDialog();
            _refresh();
        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgv.CurrentRow == null) return;

            bool isLocked = (bool)dgv.CurrentRow.Cells["IsLocked"].Value;

            editToolStripMenuItem.Enabled = !isLocked;
            takeTestToolStripMenuItem.Enabled = !isLocked;
        }
    }
}
