using DAL;
using System;
using System.Data;
namespace BLL
{
    public class clsTest
    {
        public int TestID { get; set; }


        public clsTestAppointment TestAppointment { get; set; }
        public bool TestResult { get; set; }

        public string Notes { get; set; }

        public int CreatedByUserID { get; set; }

        public enum enMode { AddNew, Update }

        public enMode Mode;


        public clsTest()

        {

            this.TestID = -1;

            TestAppointment = new clsTestAppointment();
            this.TestResult = false;

            this.Notes = "";

            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;

        }


        private clsTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)

        {

            this.TestID = TestID;
            TestAppointment = clsTestAppointment.getTestAppointmentByID(TestAppointmentID);

            this.TestResult = TestResult;

            this.Notes = Notes;

            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.Update;


        }

        public static bool isTestExistByID(int TestID)

        {

            return clsTestDAL.isTestExistByID(TestID);


        }



        public static clsTest getTestByID(int TestID)

        {

            int TestAppointmentID = -1;

            bool TestResult = false;

            string Notes = "";

            int CreatedByUserID = -1;



            if (clsTestDAL.getTestByID(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))

            {

                return new clsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);

            }

            else return null;

        }


        private bool _addTest()

        {

            this.TestID = clsTestDAL.addTest(TestAppointment.TestAppointmentID, TestResult, Notes, CreatedByUserID);

            return this.TestID > 0;

        }

        private bool _updateTest()

        {

            return clsTestDAL.updateTest(TestID, TestAppointment.TestAppointmentID, TestResult, Notes, CreatedByUserID);

        }


        public static bool deleteTest(int TestID)

        {

            if (isTestExistByID(TestID))

            {

                return clsTestDAL.deleteTest(TestID);

            }

            else return false;

        }



        public static DataTable getAll()

        {

            return clsTestDAL.getAll();

        }




        public bool Save()

        {

            switch (Mode)

            {

                case enMode.AddNew:


                    if (_addTest())
                    {
                        Mode = enMode.Update;
                        
                        return true;
                    }

                    else

                    {

                        return false;

                    }


                case enMode.Update:
                    TestAppointment.IsLocked = true;
                    return _updateTest() && TestAppointment.Save();

            }

            return true;

        }

    }

}