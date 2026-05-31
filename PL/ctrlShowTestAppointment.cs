using BLL;
using Microsoft.VisualBasic;
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
    public partial class ctrlShowTestAppointment : UserControl
    {


        public ctrlShowTestAppointment()
        {
            InitializeComponent();
        }

        private void ctrlShowTestAppoinyment_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;
            
        }
        int _ldlaID = -1;
        int _testTypeID = -1;

        public void fillFormByldlaAndTestTypeID(int ldlaID, int testTypeID)
        {
            _ldlaID = ldlaID;
            _testTypeID = testTypeID;

            clsLocalDrivingLicenseApplication licenseApplication = clsLocalDrivingLicenseApplication.getLocalDrivingLicenseApplicationID(_ldlaID);
            if (licenseApplication == null)
            {
                MessageBox.Show("Error: " + _ldlaID);

                MessageBox.Show("Error: Appointment not Found");
                return;
            }
            lblID.Text = licenseApplication.LocalDrivingLicenseApplicationID.ToString();
            clsLicenseClass licenseClass = clsLicenseClass.getLicenseClassByID(licenseApplication.LicenseClassID);
            lblLicenseClass.Text = licenseClass.ClassName;
            lblName.Text = licenseApplication.Application.Person.getFullName();

            dtpDate.Value = DateTime.Now;

            clsTestType testType = clsTestType.getTestTypeByID(testTypeID);
            if(testType.TestTypeFees == (int)testType.TestTypeFees)
            {
                lblFees.Text = ((int)testType.TestTypeFees).ToString() + "$";
            }
            else lblFees.Text = testType.TestTypeFees.ToString() + "$";
            _chooseImage(testType.TestTypeID);
            lblTrial.Text = clsLocalDrivingLicenseApplication.getTrialsByAppAndTestID(_ldlaID, _testTypeID).ToString();

        }

        public void fillFormByAppointmentID(int appointmentID, bool isEdit = false)
        {
            clsTestAppointment testAppointment = clsTestAppointment.getTestAppointmentByID(appointmentID);
            if (testAppointment == null)
            {
                MessageBox.Show("Error: Appointment not Found");
                return;
            }
            this._ldlaID = testAppointment.LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
            this._testTypeID = testAppointment.TestTypeID;


            lblID.Text = testAppointment.LocalDrivingLicenseApplication.ToString();
            clsLicenseClass licenseClass = clsLicenseClass.getLicenseClassByID(testAppointment.LocalDrivingLicenseApplication.LicenseClassID);
            lblLicenseClass.Text = licenseClass.ClassName;
            lblName.Text = testAppointment.LocalDrivingLicenseApplication.Application.Person.getFullName();
            dtpDate.Value = testAppointment.AppointmentDate;

            dtpDate.Enabled = isEdit;

            clsTestType testType = clsTestType.getTestTypeByID(testAppointment.TestTypeID);
            if (testType.TestTypeFees == (int)testType.TestTypeFees)
            {
                lblFees.Text = ((int)testType.TestTypeFees).ToString() + "$";
            }
            else lblFees.Text = testType.TestTypeFees.ToString() + "$";
            _chooseImage(testType.TestTypeID);
            lblTrial.Text = clsLocalDrivingLicenseApplication.getTrialsByAppAndTestID(testAppointment.LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, testAppointment.TestTypeID).ToString();
        }


        private void _chooseImage(int TestTypeID)
        {

            switch(TestTypeID)
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

        public int testAppointment(int retakeAppID = -1, int testAppointmentID = -1)
        {
            clsTestAppointment testAppointment;

            if (testAppointmentID != -1)
            {
                testAppointment = clsTestAppointment.getTestAppointmentByID(testAppointmentID);
                if (testAppointment == null || testAppointment.IsLocked)
                {
                    MessageBox.Show("Error: the Appointment is not exists or locked already.");
                    return -1;
                }
            }
            else
            {
                testAppointment = new clsTestAppointment();
            }

            clsLocalDrivingLicenseApplication ldla = clsLocalDrivingLicenseApplication.getLocalDrivingLicenseApplicationID(_ldlaID);
            int lastAppID = -1;

            if (testAppointment.RetakeID > 0)
            {
                lastAppID = ldla.lastTestAppointmentID(_testTypeID);
            }
            else
            {
                lastAppID = ldla.lastTestAppointmentID(_testTypeID - 1);
            }

            if (lastAppID != -1 && lastAppID != testAppointmentID) 
            {
                clsTestAppointment lastApp = clsTestAppointment.getTestAppointmentByID(lastAppID);
                if (dtpDate.Value < lastApp.AppointmentDate)
                {
                    MessageBox.Show("Error: You cannot book an appointment that its date before last test date.");
                    return -1;
                }
            }

            testAppointment.AppointmentDate = dtpDate.Value;
            testAppointment.PaidFees = Convert.ToDecimal(lblFees.Text.TrimEnd('$'));
            testAppointment.LocalDrivingLicenseApplication = ldla;
            testAppointment.CreatedByUserID = clsHelper.user.UserID;
            testAppointment.IsLocked = false;
            testAppointment.TestTypeID = _testTypeID;

            testAppointment.RetakeID = retakeAppID; 

            if (testAppointment.Save())
            {
                return testAppointment.TestAppointmentID;
            }
            else
            {
                MessageBox.Show("failed saving appointment in the database");
                return -1;
            }
        }
    }
}
