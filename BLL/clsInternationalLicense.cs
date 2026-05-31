
using DAL;

using System;

using System.Data;


namespace BLL

{

    public class clsInternationalLicense

    {

        public int InternationalLicenseID { get; set; }

        public int ApplicationID { get; set; }

        public int DriverID { get; set; }

        public int IssuedUsingLocalLicenseID { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public bool IsActive { get; set; }

        public int CreatedByUserID { get; set; }

        public enum enMode { AddNew, Update }

        public enMode Mode;


        public clsInternationalLicense()

        {

            this.InternationalLicenseID = -1;

            this.ApplicationID = -1;

            this.DriverID = -1;

            this.IssuedUsingLocalLicenseID = -1;

            this.IssueDate = DateTime.Now;

            this.ExpirationDate = DateTime.Now.AddYears(1);

            this.IsActive = false;

            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;

        }



        private clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)

        {

            this.InternationalLicenseID = InternationalLicenseID;

            this.ApplicationID = ApplicationID;

            this.DriverID = DriverID;

            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;

            this.IssueDate = IssueDate;

            this.ExpirationDate = ExpirationDate;

            this.IsActive = IsActive;

            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.Update;


        }


        private bool _addInternationalLicense()

        {

            this.InternationalLicenseID = clsInternationalLicenseDAL.addInternationalLicense(ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);

            return this.InternationalLicenseID > 0;

        }


        private bool _updateInternationalLicense()

        {

            return clsInternationalLicenseDAL.updateInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);

        }



        public bool Save()

        {

            switch (Mode)

            {

                case enMode.AddNew:


                    if (_addInternationalLicense())

                    {


                        Mode = enMode.Update;

                        return true;

                    }

                    else

                    {

                        return false;

                    }


                case enMode.Update: return _updateInternationalLicense();

            }

            return true;

        }



        public static clsInternationalLicense getInternationalLicenseByID(int InternationalLicenseID)

        {

            int ApplicationID = -1;

            int DriverID = -1;

            int IssuedUsingLocalLicenseID = -1;

            DateTime IssueDate = DateTime.Now;

            DateTime ExpirationDate = DateTime.Now;

            bool IsActive = false;

            int CreatedByUserID = -1;



            if (clsInternationalLicenseDAL.getInternationalLicenseByID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))

            {

                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);

            }

            else return null;

        }


        public static clsInternationalLicense getInternationalLicenseByDriverID(int DriverID)

        {

            int ApplicationID = -1;

            int InternationalLicenseID = -1;
            int IssuedUsingLocalLicenseID = -1;

            DateTime IssueDate = DateTime.Now;

            DateTime ExpirationDate = DateTime.Now;

            bool IsActive = false;

            int CreatedByUserID = -1;



            if (clsInternationalLicenseDAL.getInternationalLicenseByDriverID(ref InternationalLicenseID, ref ApplicationID, DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))

            {

                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);

            }

            else return null;

        }




        public static DataTable getAll()

        {

            return clsInternationalLicenseDAL.getAll();

        }





        public static DataTable getAllByDriverID(int DriverID)

        {

            if (isInternationalLicenseExistByDriverID(DriverID))

            {

                return clsInternationalLicenseDAL.getAllByDriverID(DriverID);

            }

            return new DataTable();

        }





        public static bool deleteInternationalLicense(int InternationalLicenseID)

        {

            if (isInternationalLicenseExistByID(InternationalLicenseID))

            {

                return clsInternationalLicenseDAL.deleteInternationalLicense(InternationalLicenseID);

            }

            else return false;

        }



        public static bool isInternationalLicenseExistByID(int InternationalLicenseID)

        {

            return clsInternationalLicenseDAL.isInternationalLicenseExistByID(InternationalLicenseID);


        }



        public static bool isInternationalLicenseExistByDriverID(int DriverID)

        {

            return clsInternationalLicenseDAL.isInternationalLicenseExistByDriverID(DriverID);


        }



    }

}