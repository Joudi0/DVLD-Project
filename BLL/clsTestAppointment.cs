using DAL;
using System;
using System.Data;
namespace BLL
{
    public class clsTestAppointment
    {
        public int TestAppointmentID { get; set; }

        public int RetakeID { get; set; }


        public int TestTypeID { get; set; }
        public clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication { get; set; }
        public DateTime AppointmentDate { get; set; }

        public decimal PaidFees { get; set; }

        public int CreatedByUserID { get; set; }

        public bool IsLocked { get; set; }

        public enum enMode { AddNew, Update }

        public enMode Mode;


        public clsTestAppointment()

        {

            this.TestAppointmentID = -1;

            this.TestTypeID = -1;

            LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();

            this.AppointmentDate = DateTime.Now;

            this.PaidFees = -1;

            this.CreatedByUserID = -1;


            Mode = enMode.AddNew;

        }


        private clsTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int retakeID)

        {

            this.TestAppointmentID = TestAppointmentID;

            this.TestTypeID = TestTypeID;

            this.LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.getLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);

            this.AppointmentDate = AppointmentDate;

            this.PaidFees = PaidFees;

            this.CreatedByUserID = CreatedByUserID;

            this.IsLocked = IsLocked;

            this.RetakeID = retakeID;

            Mode = enMode.Update;
         }

        public static bool isTestAppointmentExistByID(int TestAppointmentID)

        {

            return clsTestAppointmentDAL.isTestAppointmentExistByID(TestAppointmentID);


        }


        public static bool DeleteAllTestAppointments(int ldlaID)
        {
            return clsTestAppointmentDAL.deleteAllTestAppointment(ldlaID);
        }
        public static clsTestAppointment getTestAppointmentByID(int TestAppointmentID)

        {

            int TestTypeID = -1;

            int LocalDrivingLicenseApplicationID = -1;

            DateTime AppointmentDate = DateTime.Now;

            decimal PaidFees = -1;

            int CreatedByUserID = -1;

            bool IsLocked = false;
            int RetakeID = -1;


            if (clsTestAppointmentDAL.getTestAppointmentByID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeID))

            {

                return new clsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeID);

            }

            else return null;

        }


        private bool _addTestAppointment()

        {

            this.TestAppointmentID = clsTestAppointmentDAL.addTestAppointment(TestTypeID, LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeID);

            return this.TestAppointmentID > 0;

        }

        private bool _updateTestAppointment()

        {

            return clsTestAppointmentDAL.updateTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeID);

        }


        public static bool deleteTestAppointment(int TestAppointmentID)

        {

            if (isTestAppointmentExistByID(TestAppointmentID))

            {

                return clsTestAppointmentDAL.deleteTestAppointment(TestAppointmentID);

            }

            else return false;

        }

        public static DataTable getAll()
        {
            return clsTestAppointmentDAL.getAll();

        }

        public bool Save()
        {
            switch (Mode)
            {

                case enMode.AddNew:


                    if (_addTestAppointment())

                    {


                        Mode = enMode.Update;

                        return true;

                    }

                    else

                    {

                        return false;

                    }


                case enMode.Update: return _updateTestAppointment();

            }

            return true;

        }

    }

}