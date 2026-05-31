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
    public partial class frmTakeTest : Form
    {
        public frmTakeTest(int appointmentID)
        {
            InitializeComponent();
            _appointmentID = appointmentID;

        }

        int _appointmentID = -1;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_check())
            {
                _save();
            }
        }

        private bool _check()
        {
            if (!rbPass.Checked && !rbFail.Checked)
            {
                MessageBox.Show("Error: You must choose the Result");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void _save()
        {
            clsTest test = new clsTest();
            test.Notes = tbNotes.Text;
            test.TestResult = rbPass.Checked;
            test.CreatedByUserID = clsHelper.user.UserID;
            test.TestAppointment.TestAppointmentID = _appointmentID;
            
            clsTestAppointment testAppointment = clsTestAppointment.getTestAppointmentByID(_appointmentID);
            if (testAppointment == null)
            {
                MessageBox.Show("The appointment ID passed doesn't exist in the database. Check the ID value!");
                return;
            }

            if (test.Save())
            {
                testAppointment.IsLocked = true;
                MessageBox.Show("Test Result Saved Successfully!.");
                lblTestID.Text = test.TestID.ToString();
                btnSave.Enabled = false;
                if (!testAppointment.Save())
                {
                    MessageBox.Show($"Warning: Test Appointment ID: {testAppointment.TestAppointmentID} was not locked");

                }
            }
            else
            {
                MessageBox.Show("Test Result Saving Failed!.");

            }

        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            clsTestAppointment testAppointment = clsTestAppointment.getTestAppointmentByID( _appointmentID);
            if (testAppointment == null) return;
            
            ctrlShowTestAppointment1.fillFormByAppointmentID(testAppointment.TestAppointmentID);
        }
    }
}
