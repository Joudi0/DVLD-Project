using DAL;

using System;

using System.Data;

namespace BLL

{

    public class clsApplicationType

    {


        public int ApplicationTypeID { get; set; }

        public string ApplicationTypeTitle { get; set; }

        public decimal ApplicationFees { get; set; }


        public clsApplicationType()

        {

            this.ApplicationTypeID = -1;

            this.ApplicationTypeTitle = "";

            this.ApplicationFees = -1;

        }

        private clsApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)

        {

            this.ApplicationTypeID = ApplicationTypeID;

            this.ApplicationTypeTitle = ApplicationTypeTitle;

            this.ApplicationFees = ApplicationFees;
        }



        public static clsApplicationType getApplicationTypeByID(int ApplicationTypeID)

        {

            string ApplicationTypeTitle = "";

            decimal ApplicationFees = -1;



            if (clsApplicationTypeDAL.getApplicationTypeByApplicationTypeID(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))

            {

                return new clsApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);

            }

            else return null;

        }



        public bool updateApplicationType()

        {

            return clsApplicationTypeDAL.updateApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);

        }



        public static DataTable getAll()

        {

            return clsApplicationTypeDAL.getAll();

        }


    }

}



