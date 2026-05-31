using DAL;

using System;
using System.Data;
namespace BLL
{
    public class clsLicenseClass
    {
        public int LicenseClassID { get; set; }

        public string ClassName { get; set; }

        public string ClassDescription { get; set; }

        public byte MinimumAllowedAge { get; set; }

        public byte DefaultValidityLength { get; set; }

        public decimal ClassFees { get; set; }

        public enum enMode { AddNew, Update }

        public enMode Mode;


        private clsLicenseClass(int LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;

            this.ClassName = ClassName;

            this.ClassDescription = ClassDescription;

            this.MinimumAllowedAge = MinimumAllowedAge;

            this.DefaultValidityLength = DefaultValidityLength;

            this.ClassFees = ClassFees;

            Mode = enMode.Update;
        }

        public static bool isLicenseClassExistByID(int LicenseClassID)
        {
            return clsLicenseClassDAL.isLicenseClassExistByID(LicenseClassID);


        }

        public static clsLicenseClass getLicenseClassByID(int LicenseClassID)
        {

            string ClassName = "";

            string ClassDescription = "";

            byte MinimumAllowedAge = 0;

            byte DefaultValidityLength = 0;

            decimal ClassFees = -1;

            if (clsLicenseClassDAL.getLicenseClassByID(LicenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else return null;
        }

        public static DataTable getAll()
        {
            return clsLicenseClassDAL.getAll();
        }

        public static DataTable getAllNames()
        {
            return clsLicenseClassDAL.getAllNames();
        }

    }

}