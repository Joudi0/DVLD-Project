using DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class clsTestAppointmentDAL
    {

        public static bool getTestAppointmentByID(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int RetakeID)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try

            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())

                {

                    isFound = true;

                    TestTypeID = (int)reader["TestTypeID"];

                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];

                    AppointmentDate = (DateTime)reader["AppointmentDate"];

                    PaidFees = (decimal)reader["PaidFees"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    IsLocked = (bool)reader["IsLocked"];

                    if(reader["RetakeTestApplicationID"] != DBNull.Value) RetakeID = (int)reader["RetakeTestApplicationID"];
                    else RetakeID = -1;



                }

                reader.Close();

            }


            catch (Exception ex) { isFound = false; throw; }


            finally { connection.Close(); }

            return isFound;

        }

        public static bool updateTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeID)

        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = @"UPDATE TestAppointments SET

                    TestTypeID = @TestTypeID,

                    LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,

                    AppointmentDate = @AppointmentDate,

                    PaidFees = @PaidFees,

                    CreatedByUserID = @CreatedByUserID,

                    IsLocked = @IsLocked,

                    RetakeTestApplicationID = @RetakeID WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue(@"TestAppointmentID", TestAppointmentID);

            command.Parameters.AddWithValue(@"TestTypeID", TestTypeID);

            command.Parameters.AddWithValue(@"LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            command.Parameters.AddWithValue(@"AppointmentDate", AppointmentDate);

            command.Parameters.AddWithValue(@"PaidFees", PaidFees);

            command.Parameters.AddWithValue(@"CreatedByUserID", CreatedByUserID);

            command.Parameters.AddWithValue(@"IsLocked", IsLocked);
            if(RetakeID > 0 )  command.Parameters.AddWithValue(@"RetakeID", RetakeID);
            else command.Parameters.AddWithValue(@"RetakeID", DBNull.Value);

            try

            {

                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }

            catch (Exception) { return false; }

            finally { connection.Close(); }


            return (rowsAffected > 0);

        }

        public static int addTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeID)

        {

            int TestAppointmentID = -1;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = @"INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID)

VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeID);

SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue(@"TestTypeID", TestTypeID);

            command.Parameters.AddWithValue(@"LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            command.Parameters.AddWithValue(@"AppointmentDate", AppointmentDate);

            command.Parameters.AddWithValue(@"PaidFees", PaidFees);

            command.Parameters.AddWithValue(@"CreatedByUserID", CreatedByUserID);

            command.Parameters.AddWithValue(@"IsLocked", IsLocked);
            if(RetakeID > 0) command.Parameters.AddWithValue(@"RetakeID", RetakeID);
            else command.Parameters.AddWithValue(@"RetakeID", DBNull.Value);

            try

                {

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))

                    {

                        TestAppointmentID = insertedID;

                    }

                }

                catch (Exception) { }

                finally { connection.Close(); }


            return TestAppointmentID;

        }

        public static bool deleteTestAppointment(int TestAppointmentID)

        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "DELETE FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try

            {

                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }

            catch (Exception) { throw; }

            finally { connection.Close(); }

            return (rowsAffected > 0);

        }

        public static bool deleteAllTestAppointment(int ldlaID)

        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "DELETE FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @ldlaID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ldlaID", ldlaID);

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

            string query = "SELECT * FROM TestAppointments_View";

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


        public static bool isTestAppointmentExistByID(int TestAppointmentID)

        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT Found=1 FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


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