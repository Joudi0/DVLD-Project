using DAL;
using System;
using System.Data;
namespace BLL
{
    public class clsLocalDrivingLicenseApplication
    {

        public int LocalDrivingLicenseApplicationID { get; set; }

        public clsApplication Application { get; set; }
        
        public int LicenseClassID { get; set; }

        public enum enMode { AddNew, Update }

        public enMode Mode;


        public static int examsPassedByID(int id)
        {
            return clsLocalDrivingLicenseApplicationDAL.examsPassedByID(id);
        }

        public int examsPassed()
        {
            return clsLocalDrivingLicenseApplicationDAL.examsPassedByID(LocalDrivingLicenseApplicationID);
        }

        public int lastTestAppointmentID(int testTypeID)
        {
            return clsLocalDrivingLicenseApplicationDAL.lastTestAppointmentID(LocalDrivingLicenseApplicationID, testTypeID);
        }

        public clsLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            Application = new clsApplication();
            this.LicenseClassID = -1;
            Mode = enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.Application = clsApplication.getApplicationbyApplicationID(ApplicationID);
            this.LicenseClassID = LicenseClassID;
            Mode = enMode.Update;

        }

        public static int getTrialsByAppAndTestID(int LocalDrivingLicenseApplicationID, int testTypeID)
        {
            return clsLocalDrivingLicenseApplicationDAL.getTrialsByAppAndTestID(LocalDrivingLicenseApplicationID, testTypeID);
        }

        public static bool isLocalDrivingLicenseApplicationExistByID(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationDAL.isLocalDrivingLicenseApplicationExistByID(LocalDrivingLicenseApplicationID);
        }

        public static bool isLocalLicenseAppExistByPersonIDAndClassID(int PersonID, int LicenseClassID)
        {
            return clsLocalDrivingLicenseApplicationDAL.isLocalDrivingLicenseApplicationExistByPersonIDAndClassID(PersonID, LicenseClassID);
        }
        public static clsLocalDrivingLicenseApplication getLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1;

            int LicenseClassID = -1;

            if (clsLocalDrivingLicenseApplicationDAL.getLocalDrivingLicenseApplicationByID(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
            {

                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);

            }
            else return null;
        }



        private bool _addLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationDAL.addLocalDrivingLicenseApplication(Application.ApplicationID, LicenseClassID);
            return this.LocalDrivingLicenseApplicationID > 0;
        }

        private bool _updateLocalDrivingLicenseApplication()
        {

            return clsLocalDrivingLicenseApplicationDAL.updateLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, Application.ApplicationID, LicenseClassID);

        }



        public static bool deleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)

        {

            if (isLocalDrivingLicenseApplicationExistByID(LocalDrivingLicenseApplicationID))

            {

                return clsLocalDrivingLicenseApplicationDAL.deleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);

            }

            else return false;

        }

        public static DataTable getAll()
        {
            return clsLocalDrivingLicenseApplicationDAL.getAll();
        }

        public static DataTable getAllView()
        {
            return clsLocalDrivingLicenseApplicationDAL.getAllView();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew: 
                    
                    
                    if (Application.Save() && _addLocalDrivingLicenseApplication())
                    {
                        Mode = enMode.Update;
                        return true;

                    }
                    else
                    {

                        return false;

                    }
                case enMode.Update:
                    if (Application.Save()) return _updateLocalDrivingLicenseApplication();
                    else break;
            }
            return true;
        }
    }
}