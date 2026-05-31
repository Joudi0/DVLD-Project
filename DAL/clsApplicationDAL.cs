using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;


namespace DAL

{

    public class clsApplicationDAL

    {

        public static bool getApplicationByApplicationID(int ApplicationID, ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID, ref byte ApplicationStatus, ref DateTime LastStatusDate, ref decimal PaidFees, ref int CreatedByUserID)

        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try

            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())

                {

                    isFound = true;

                    ApplicantPersonID = (int)reader["ApplicantPersonID"];

                    ApplicationDate = (DateTime)reader["ApplicationDate"];

                    ApplicationTypeID = (int)reader["ApplicationTypeID"];

                    ApplicationStatus = (byte)reader["ApplicationStatus"];

                    LastStatusDate = (DateTime)reader["LastStatusDate"];

                    PaidFees = (decimal)reader["PaidFees"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];


                }

                reader.Close();

            }


            catch (Exception ex) { isFound = false; throw; }


            finally { connection.Close(); }

            return isFound;

        }

        public static bool updateApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)

        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = @"UPDATE Applications SET

                    ApplicantPersonID = @ApplicantPersonID,

                    ApplicationDate = @ApplicationDate,

                    ApplicationTypeID = @ApplicationTypeID,

                    ApplicationStatus = @ApplicationStatus,

                    LastStatusDate = @LastStatusDate,

                    PaidFees = @PaidFees,

                    CreatedByUserID = @CreatedByUserID WHERE ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue(@"ApplicationID", ApplicationID);

            command.Parameters.AddWithValue(@"ApplicantPersonID", ApplicantPersonID);

            command.Parameters.AddWithValue(@"ApplicationDate", ApplicationDate);

            command.Parameters.AddWithValue(@"ApplicationTypeID", ApplicationTypeID);

            command.Parameters.AddWithValue(@"ApplicationStatus", ApplicationStatus);

            command.Parameters.AddWithValue(@"LastStatusDate", LastStatusDate);

            command.Parameters.AddWithValue(@"PaidFees", PaidFees);

            command.Parameters.AddWithValue(@"CreatedByUserID", CreatedByUserID);

            try

            {

                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }

            catch (Exception) { return false; }

            finally { connection.Close(); }


            return (rowsAffected > 0);

        }

        public static int addApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)

        {

            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = @"INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)

VALUES (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);

SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue(@"ApplicantPersonID", ApplicantPersonID);

            command.Parameters.AddWithValue(@"ApplicationDate", ApplicationDate);

            command.Parameters.AddWithValue(@"ApplicationTypeID", ApplicationTypeID);

            command.Parameters.AddWithValue(@"ApplicationStatus", ApplicationStatus);

            command.Parameters.AddWithValue(@"LastStatusDate", LastStatusDate);

            command.Parameters.AddWithValue(@"PaidFees", PaidFees);

            command.Parameters.AddWithValue(@"CreatedByUserID", CreatedByUserID);

            try

            {

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))

                {

                    PersonID = insertedID;

                }

            }

            catch (Exception) { }

            finally { connection.Close(); }


            return PersonID;

        }

        public static bool deleteApplication(int ApplicationID)

        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "DELETE FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try

            {

                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }

            catch (Exception) { throw; }

            finally { connection.Close(); }

            return (rowsAffected > 0);

        }


        public static DataTable getAll()

        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT * FROM Applications";

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


        public static bool isApplicationExistByApplicationID(int ApplicationID)

        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT Found=1 FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


            try

            {

                connection.Open();

                object result = command.ExecuteScalar();

                isFound = (result != null);

            }

            catch (Exception) { }

            finally { connection.Close(); }


            return isFound;

        }

    }

}
