using DAL;
using System;
using System.Data;
namespace BLL
{
    public class clsDetainedLicense
    {
        public int DetainID { get; set; }

        public int LicenseID { get; set; }

        public DateTime DetainDate { get; set; }

        public decimal FineFees { get; set; }

        public int CreatedByUserID { get; set; }

        public bool IsReleased { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int ReleasedByUserID { get; set; }

        public int ReleaseApplicationID { get; set; }

        public enum enMode { AddNew, Update }

        public enMode Mode;


        public clsDetainedLicense()

        {

            this.DetainID = -1;

            this.LicenseID = -1;

            this.DetainDate = DateTime.Now;

            this.FineFees = -1;

            this.CreatedByUserID = -1;

            this.IsReleased = false;

            this.ReleaseDate = DateTime.Now;

            this.ReleasedByUserID = -1;

            this.ReleaseApplicationID = -1;

            Mode = enMode.AddNew;

        }


        
        private clsDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)

        {

            this.DetainID = DetainID;

            this.LicenseID = LicenseID;

            this.DetainDate = DetainDate;

            this.FineFees = FineFees;

            this.CreatedByUserID = CreatedByUserID;

            this.IsReleased = IsReleased;

            this.ReleaseDate = ReleaseDate;

            this.ReleasedByUserID = ReleasedByUserID;

            this.ReleaseApplicationID = ReleaseApplicationID;

            Mode = enMode.Update;


        }


        private bool _addDetainedLicense()

        {

            this.DetainID = clsDetainedLicenseDAL.addDetainedLicense(LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);

            return this.DetainID > 0;

        }


        private bool _updateDetainedLicense()

        {

            return clsDetainedLicenseDAL.updateDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);

        }



        public bool Save()

        {

            switch (Mode)

            {

                case enMode.AddNew:


                    if (_addDetainedLicense())

                    {


                        Mode = enMode.Update;

                        return true;

                    }

                    else

                    {

                        return false;

                    }


                case enMode.Update: return _updateDetainedLicense();

            }

            return true;

        }



        public static clsDetainedLicense getDetainedLicenseByID(int DetainID)

        {

            int LicenseID = -1;

            DateTime DetainDate = DateTime.Now;

            decimal FineFees = -1;

            int CreatedByUserID = -1;

            bool IsReleased = false;

            DateTime ReleaseDate = DateTime.Now;

            int ReleasedByUserID = -1;

            int ReleaseApplicationID = -1;



            if (clsDetainedLicenseDAL.getDetainedLicenseByID(DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))

            {

                return new clsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);

            }

            else return null;

        }



        public static clsDetainedLicense getDetainedLicenseByLicenseID(int LicenseID)

        {

            int DetainID = -1;

            DateTime DetainDate = DateTime.Now;

            decimal FineFees = -1;

            int CreatedByUserID = -1;

            bool IsReleased = false;

            DateTime ReleaseDate = DateTime.Now;

            int ReleasedByUserID = -1;

            int ReleaseApplicationID = -1;



            if (clsDetainedLicenseDAL.getDetainedLicenseByLicenseID(ref DetainID, LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))

            {

                return new clsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);

            }

            else return null;

        }


        public static DataTable getAll()

        {

            return clsDetainedLicenseDAL.getAll();

        }





        public static DataTable getAllByLicenseID(int LicenseID)

        {

            if (isDetainedLicenseExistByLicenseID(LicenseID))

            {

                return clsDetainedLicenseDAL.getAllByLicenseID(LicenseID);

            }

            return new DataTable();

        }





        public static bool deleteDetainedLicense(int DetainID)

        {

            if (isDetainedLicenseExistByID(DetainID))

            {

                return clsDetainedLicenseDAL.deleteDetainedLicense(DetainID);

            }

            else return false;

        }



        public static bool isDetainedLicenseExistByID(int DetainID)

        {

            return clsDetainedLicenseDAL.isDetainedLicenseExistByID(DetainID);


        }



        public static bool isDetainedLicenseExistByLicenseID(int LicenseID)

        {

            return clsDetainedLicenseDAL.isDetainedLicenseExistByLicenseID(LicenseID);


        }



    }

}