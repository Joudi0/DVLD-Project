using DAL;
using System;
using System.Data;
namespace BLL
{
    public class clsApplication
    {
        public int ApplicationID { get; set; }

        public clsPerson Person { get; set; }
        public DateTime ApplicationDate { get; set; }

        public int ApplicationTypeID { get; set; }

        public byte ApplicationStatus { get; set; }

        public DateTime LastStatusDate { get; set; }

        public decimal PaidFees { get; set; }

        public int CreatedByUserID { get; set; }

        public enum enMode { AddNew, Update }

        public enMode Mode;



        public clsApplication()

        {

            this.ApplicationID = -1;

            this.Person = new clsPerson();

            this.ApplicationDate = DateTime.Now;

            this.ApplicationTypeID = -1;

            this.ApplicationStatus = 0;

            this.LastStatusDate = DateTime.Now;

            this.PaidFees = -1;

            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;

        }



        private clsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)

        {

            this.ApplicationID = ApplicationID;

            this.Person = clsPerson.getPersonByID(ApplicantPersonID);

            this.ApplicationDate = ApplicationDate;

            this.ApplicationTypeID = ApplicationTypeID;

            this.ApplicationStatus = ApplicationStatus;

            this.LastStatusDate = LastStatusDate;

            this.PaidFees = PaidFees;

            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.Update;


        }


        public static bool isApplicationExistByApplicationID(int ApplicationID)

        {

            return clsApplicationDAL.isApplicationExistByApplicationID(ApplicationID);


        }




        public static clsApplication getApplicationbyApplicationID(int ApplicationID)

        {

            int ApplicantPersonID = -1;

            DateTime ApplicationDate = DateTime.Now;

            int ApplicationTypeID = -1;

            byte ApplicationStatus = 0;

            DateTime LastStatusDate = DateTime.Now;

            decimal PaidFees = -1;

            int CreatedByUserID = -1;



            if (clsApplicationDAL.getApplicationByApplicationID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))

            {

                return new clsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);

            }

            else return null;

        }



        private bool _addApplication()

        {

            this.ApplicationID = clsApplicationDAL.addApplication(this.Person.PersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);

            return this.ApplicationID > 0;

        }


        private bool _updateApplication()

        {

            return clsApplicationDAL.updateApplication(ApplicationID, this.Person.PersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);

        }



        public static bool deleteApplication(int ApplicationID)

        {

            if (isApplicationExistByApplicationID(ApplicationID))

            {

                return clsApplicationDAL.deleteApplication(ApplicationID);

            }

            else return false;

        }




        public static DataTable getAll()

        {

            return clsApplicationDAL.getAll();

        }





        public bool Save()

        {

            switch (Mode)

            {

                case enMode.AddNew:


                    if (_addApplication())

                    {


                        Mode = enMode.Update;

                        return true;

                    }
                    else

                    {

                        return false;

                    }
                case enMode.Update: return _updateApplication();
            }
            return true;
        }
    }
}