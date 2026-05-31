using DAL;
using System;
using System.Data;
namespace BLL
{
    public class clsDriver
    {
        public int DriverID { get; set; }

        public clsPerson Person { get; set; }

        public int CreatedByUserID { get; set; }

        public DateTime CreatedDate { get; set; }

        public enum enMode { AddNew, Update }

        public enMode Mode;


        public clsDriver()

        {

            this.DriverID = -1;

            this.Person = new clsPerson();

            this.CreatedByUserID = -1;

            this.CreatedDate = DateTime.Now;

            Mode = enMode.AddNew;

        }


        private clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)

        {

            this.DriverID = DriverID;

            this.Person = clsPerson.getPersonByID(PersonID);

            this.CreatedByUserID = CreatedByUserID;

            this.CreatedDate = CreatedDate;

            Mode = enMode.Update;


        }

        public static bool isDriverExistByID(int DriverID)

        {

            return clsDriverDAL.isDriverExistByID(DriverID);


        }



        public static clsDriver getDriverByID(int DriverID)

        {

            int PersonID = -1;

            int CreatedByUserID = -1;

            DateTime CreatedDate = DateTime.Now;



            if (clsDriverDAL.getDriverByID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))

            {

                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);

            }

            else return null;

        }



        public static clsDriver getDriverByPersonID(int PersonID)

        {

            int DriverID = -1;

            int CreatedByUserID = -1;

            DateTime CreatedDate = DateTime.Now;



            if (clsDriverDAL.getDriverByPersonID(ref DriverID, PersonID, ref CreatedByUserID, ref CreatedDate))

            {

                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);

            }

            else return null;

        }


        private bool _addDriver()

        {

            this.DriverID = clsDriverDAL.addDriver(Person.PersonID, CreatedByUserID, CreatedDate);

            return this.DriverID > 0;

        }

        private bool _updateDriver()

        {

            return clsDriverDAL.updateDriver(DriverID, Person.PersonID, CreatedByUserID, CreatedDate);

        }


        public static bool deleteDriver(int DriverID)

        {

            if (isDriverExistByID(DriverID))

            {

                return clsDriverDAL.deleteDriver(DriverID);

            }

            else return false;

        }



        public static DataTable getAll()

        {

            return clsDriverDAL.getAll();

        }


        public static DataTable getAllView()
        {
            return clsDriverDAL.getAllView();
        }


        public bool Save()

        {

            switch (Mode)

            {

                case enMode.AddNew:


                    if (_addDriver())

                    {


                        Mode = enMode.Update;

                        return true;

                    }

                    else

                    {

                        return false;

                    }


                case enMode.Update: return _updateDriver();

            }

            return true;

        }

    }

}



