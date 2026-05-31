
using Microsoft.Data.SqlClient;

using System;

using System.Collections.Generic;

using System.Data;


namespace DAL

{

    public class clsTestTypeDAL

    {

        public static bool getTestTypeByTestTypeID(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref decimal TestTypeFees)

        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try

            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())

                {

                    isFound = true;

                    TestTypeTitle = (string)reader["TestTypeTitle"];

                    TestTypeDescription = (string)reader["TestTypeDescription"];

                    TestTypeFees = (decimal)reader["TestTypeFees"];


                }

                reader.Close();

            }


            catch (Exception ex) { isFound = false; throw; }


            finally { connection.Close(); }

            return isFound;

        }

        public static bool updateTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)

        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = @"UPDATE TestTypes SET

                    TestTypeTitle = @TestTypeTitle,

                    TestTypeDescription = @TestTypeDescription,

                    TestTypeFees = @TestTypeFees WHERE TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue(@"TestTypeID", TestTypeID);

            command.Parameters.AddWithValue(@"TestTypeTitle", TestTypeTitle);

            command.Parameters.AddWithValue(@"TestTypeDescription", TestTypeDescription);

            command.Parameters.AddWithValue(@"TestTypeFees", TestTypeFees);

            try

            {

                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }

            catch (Exception) { return false; }

            finally { connection.Close(); }


            return (rowsAffected > 0);

        }


        public static DataTable getAll()

        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT * FROM TestTypes";

            SqlCommand command = new SqlCommand(query, connection);


            try

            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) dt.Load(reader);

                reader.Close();

            }

            catch (Exception) { }

            finally { connection.Close(); }


            return dt;

        }

    }

}









