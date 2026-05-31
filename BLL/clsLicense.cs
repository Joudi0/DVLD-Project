using DAL;
using System;
using System.Data;
namespace BLL
{
    public class clsLicense
    {
        public int LicenseID { get; set; }

        public clsApplication Application { get; set; }

        public int DriverID { get; set; }

        public int LicenseClass { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string Notes { get; set; }

        public decimal PaidFees { get; set; }

        public bool IsActive { get; set; }

        public int CreatedByUserID { get; set; }

        public enum enMode { AddNew, Update }

        public enum enIssueReason { FirstTime = 1, ReNew, Repleacement, ReleaseDetained}

        public enIssueReason issueReason = enIssueReason.FirstTime;

        public enMode Mode;

        public string getIssueReason()
        {
            string reason = "";
            switch(issueReason)
            {
                case enIssueReason.FirstTime: reason = "First Time"; break;
                case enIssueReason.Repleacement: reason = "Replacement"; break;
                case enIssueReason.ReNew: reason = "Re-New"; break;
                case enIssueReason.ReleaseDetained: reason = "Release Fro Detained"; break;
            }
            return reason;
        }

        public clsLicense()
        {
            this.LicenseID = -1;

            this.Application = new clsApplication();

            this.DriverID = -1;

            this.LicenseClass = -1;

            this.IssueDate = DateTime.Now;

            this.ExpirationDate = DateTime.Now.AddYears(10);

            this.Notes = "";

            this.PaidFees = -1;

            this.IsActive = false;

            this.issueReason = enIssueReason.FirstTime;

            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;

        }


        private clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)

        {

            this.LicenseID = LicenseID;

            this.Application = clsApplication.getApplicationbyApplicationID(ApplicationID);

            this.DriverID = DriverID;

            this.LicenseClass = LicenseClass;

            this.IssueDate = IssueDate;

            this.ExpirationDate = ExpirationDate;

            this.Notes = Notes;

            this.PaidFees = PaidFees;

            this.IsActive = IsActive;

            this.issueReason = (enIssueReason)IssueReason;

            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.Update;


        }

        public static bool isLicenseExistByID(int LicenseID)

        {

            return clsLicenseDAL.isLicenseExistByID(LicenseID);


        }
        public static bool isLicenseExistByDriverAndClassID(int DriverID, int LicenseClassID)
        {
            return clsLicenseDAL.isLicenseExistByDriverAndClassID(DriverID, LicenseClassID);
        }

        public static clsLicense getLicenseByDriverAndClassID(int DriverID, int licenseClassID)

        {
            int licenseID = -1;

            int ApplicationID = -1;

            DateTime IssueDate = DateTime.Now;

            DateTime ExpirationDate = DateTime.Now;

            string Notes = "";

            decimal PaidFees = -1;

            bool IsActive = false;

            byte IssueReason = 0;

            int CreatedByUserID = -1;



            if (clsLicenseDAL.getLicenseByDriverAndClassID(ref licenseID, ref ApplicationID, DriverID, licenseClassID, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))

            {

                return new clsLicense(licenseID, ApplicationID, DriverID, licenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);

            }

            else return null;

        }


        public static clsLicense getLicenseByID(int LicenseID)

        {

            int ApplicationID = -1;

            int DriverID = -1;

            int LicenseClass = -1;

            DateTime IssueDate = DateTime.Now;

            DateTime ExpirationDate = DateTime.Now;

            string Notes = "";

            decimal PaidFees = -1;

            bool IsActive = false;

            byte IssueReason = 0;

            int CreatedByUserID = -1;



            if (clsLicenseDAL.getLicenseByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))

            {

                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);

            }

            else return null;

        }


        private bool _addLicense()

        {
            clsLicenseClass lClass = clsLicenseClass.getLicenseClassByID(LicenseClass);
            this.LicenseID = clsLicenseDAL.addLicense(Application.ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, lClass.ClassFees, IsActive, (byte)issueReason, CreatedByUserID);

            return this.LicenseID > 0;

        }

        private bool _updateLicense()

        {

            return clsLicenseDAL.updateLicense(LicenseID, Application.ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, (byte)issueReason, CreatedByUserID);

        }


        public static bool deleteLicense(int LicenseID)

        {

            if (isLicenseExistByID(LicenseID))

            {

                return clsLicenseDAL.deleteLicense(LicenseID);

            }

            else return false;

        }



        public static DataTable getAll()

        {

            return clsLicenseDAL.getAll();

        }
        public static DataTable getAllWithDriverID(int DriverID)

        {

            return clsLicenseDAL.getAllByDriverID(DriverID);

        }




        public bool Save()

        {

            switch (Mode)

            {

                case enMode.AddNew:


                    if (_addLicense())

                    {


                        Mode = enMode.Update;

                        return true;

                    }

                    else

                    {

                        return false;

                    }


                case enMode.Update: return _updateLicense();

            }

            return true;

        }

    }

}