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
    public partial class frmAddTestAppointment : Form
    {
        public frmAddTestAppointment(int ldlaID, int testTypeID, int testAppointment = -1)
        {
            InitializeComponent();
            _ldlaID = ldlaID;
            _testTypeID = testTypeID;
            _testAppointmentID = testAppointment;

            if (clsLocalDrivingLicenseApplication.getTrialsByAppAndTestID(_ldlaID, _testTypeID) > 0)
            {
                ctrlRetakeTestInfo1.Visible = true;
                ctrlRetakeTestInfo1.showPrice();
            }
            else
            {
                ctrlRetakeTestInfo1.Visible = false;
            }
            if (testAppointment == -1) ctrlShowTestAppointment1.fillFormByldlaAndTestTypeID(ldlaID, testTypeID);
            else
            {
                ctrlShowTestAppointment1.fillFormByAppointmentID(_testAppointmentID, true);
                
            }
        }
        int _ldlaID = -1;
        int _testTypeID = -1;
        int _testAppointmentID = -1;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void _update()
        {
            clsTestAppointment testAppointment = clsTestAppointment.getTestAppointmentByID(_testAppointmentID);
            if (testAppointment == null) return;
            if(ctrlShowTestAppointment1.testAppointment(testAppointment.RetakeID, testAppointment.TestAppointmentID) > -1) _done();
        }

        private int _retakeID()
        {
            int retakeAppID = -1;
            clsLocalDrivingLicenseApplication ldla = clsLocalDrivingLicenseApplication.getLocalDrivingLicenseApplicationID(_ldlaID);

            if (ctrlRetakeTestInfo1.Visible)
            {
                retakeAppID = ctrlRetakeTestInfo1.CreateRetakeApplication(ldla.Application.Person.PersonID);


                if (retakeAppID == -1)
                {
                    MessageBox.Show("Error: Failed to create retake application");
                    return -1;
                }
                else return retakeAppID;
            }
            return -1;
        }

        private void _add()
        {
            clsLocalDrivingLicenseApplication ldla = clsLocalDrivingLicenseApplication.getLocalDrivingLicenseApplicationID(_ldlaID);
            if(_saveChecked(ldla)) _done();
        }

        private bool _saveChecked(clsLocalDrivingLicenseApplication ldla, int retakeAppID = -1)
        {
            int testAppointmentID = ctrlShowTestAppointment1.testAppointment();
            if (testAppointmentID < 0) return false;
            clsTestAppointment testAppointment = clsTestAppointment.getTestAppointmentByID(testAppointmentID);
            if (ldla.examsPassed() == _testTypeID - 1)
            {
                if (testAppointmentID == -1)
                {
                    MessageBox.Show("Test Appointment not Found");
                    return false;
                }
                clsTestAppointment lastTestAppointment = clsTestAppointment.getTestAppointmentByID(ldla.lastTestAppointmentID(_testTypeID));
                if (lastTestAppointment != null)
                {
                    if (testAppointment.AppointmentDate < lastTestAppointment.AppointmentDate)
                    {
                        MessageBox.Show("You cannot book an Test that its date is before the last Test");
                        return false;
                    }
                    else
                    {
                        testAppointment.RetakeID = _retakeID();
                        if (!testAppointment.Save())
                        {
                            MessageBox.Show("Test Appointment not Saved Successfully");
                            return false;
                        }
                    }
                }
                else
                {
                    if (!testAppointment.Save())
                    {
                        MessageBox.Show("Test Appointment not Saved Successfully");
                        return false;
                    }
                    
                }
                

            }
            return true;
        }

        private void _Save()
        {
            if(_testAppointmentID != -1)
            {
                _update();
                return;
            }

            _add();
            
        }

        private void _done()
        {
            MessageBox.Show("Test Appointment saved successfully!");
            btnSave.Enabled = false;
            btnCancel.Text = "Close";
        }
        private void ctrlShowTestAppointment1_Load(object sender, EventArgs e)
        {

        }

        private void frmAddTestAppointment_Load(object sender, EventArgs e)
        {

        }
    }
}
