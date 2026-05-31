
using Microsoft.Data.SqlClient;
using System;

using System.Collections.Generic;

using System.Data;


namespace DAL

{

    public class clsApplicationTypeDAL

    {

        public static bool getApplicationTypeByApplicationTypeID(int ApplicationTypeID, ref string ApplicationTypeTitle, ref decimal ApplicationFees)

        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try

            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())

                {

                    isFound = true;

                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];

                    ApplicationFees = (decimal)reader["ApplicationFees"];


                }

                reader.Close();

            }


            catch (Exception ex) { isFound = false; throw; }


            finally { connection.Close(); }

            return isFound;

        }

        public static bool updateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)

        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = @"UPDATE ApplicationTypes SET

                    ApplicationTypeTitle = @ApplicationTypeTitle,

                    ApplicationFees = @ApplicationFees WHERE ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue(@"ApplicationTypeID", ApplicationTypeID);

            command.Parameters.AddWithValue(@"ApplicationTypeTitle", ApplicationTypeTitle);

            command.Parameters.AddWithValue(@"ApplicationFees", ApplicationFees);

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

            string query = "SELECT * FROM ApplicationTypes";

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


