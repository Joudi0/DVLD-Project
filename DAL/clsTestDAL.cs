using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
namespace DAL
{
    public class clsTestDAL
    {
        public static bool getTestByID(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT * FROM Tests WHERE TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);

            try

            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())

                {

                    isFound = true;

                    TestAppointmentID = (int)reader["TestAppointmentID"];

                    TestResult = (bool)reader["TestResult"];

                    Notes = (reader["Notes"] == DBNull.Value) ? "" : (string)reader["Notes"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];


                }

                reader.Close();

            }


            catch (Exception ex) { isFound = false; throw; }


            finally { connection.Close(); }

            return isFound;

        }

        public static bool updateTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)

        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = @"UPDATE Tests SET

                    TestAppointmentID = @TestAppointmentID,

                    TestResult = @TestResult,

                    Notes = @Notes,

                    CreatedByUserID = @CreatedByUserID WHERE TestID = @TestID;";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue(@"TestID", TestID);

            command.Parameters.AddWithValue(@"TestAppointmentID", TestAppointmentID);

            command.Parameters.AddWithValue(@"TestResult", TestResult);

            command.Parameters.AddWithValue(@"Notes", string.IsNullOrEmpty(Notes) ? DBNull.Value : (object)Notes);

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

        public static int addTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)

        {

            int TestID = -1;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)

VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);

SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue(@"TestAppointmentID", TestAppointmentID);

            command.Parameters.AddWithValue(@"TestResult", TestResult);

            command.Parameters.AddWithValue(@"Notes", string.IsNullOrEmpty(Notes) ? DBNull.Value : (object)Notes);

            command.Parameters.AddWithValue(@"CreatedByUserID", CreatedByUserID);

            try

            {

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))

                {

                    TestID = insertedID;

                }

            }

            catch (Exception) { }

            finally { connection.Close(); }


            return TestID;

        }

        public static bool deleteTest(int TestID)

        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "DELETE FROM Tests WHERE TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);

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

            string query = "SELECT * FROM Tests";

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


        public static bool isTestExistByID(int TestID)

        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT Found=1 FROM Tests WHERE TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);


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