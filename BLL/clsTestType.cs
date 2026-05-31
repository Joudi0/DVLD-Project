using DAL;

using System;

using System.Data;

namespace BLL

{

    public class clsTestType

    {


        public int TestTypeID { get; set; }

        public string TestTypeTitle { get; set; }

        public string TestTypeDescription { get; set; }

        public decimal TestTypeFees { get; set; }


        public clsTestType()

        {

            this.TestTypeID = -1;

            this.TestTypeTitle = "";

            this.TestTypeDescription = "";

            this.TestTypeFees = -1;

        }



        private clsTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)

        {

            this.TestTypeID = TestTypeID;

            this.TestTypeTitle = TestTypeTitle;

            this.TestTypeDescription = TestTypeDescription;

            this.TestTypeFees = TestTypeFees;


        }



        public static clsTestType getTestTypeByID(int TestTypeID)

        {

            string TestTypeTitle = "";

            string TestTypeDescription = "";

            decimal TestTypeFees = -1;



            if (clsTestTypeDAL.getTestTypeByTestTypeID(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))

            {

                return new clsTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);

            }

            else return null;

        }



        public bool updateTestType()

        {

            return clsTestTypeDAL.updateTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);

        }



        public static DataTable getAll()

        {

            return clsTestTypeDAL.getAll();

        }





    }

}