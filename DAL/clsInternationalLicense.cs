

using Microsoft.Data.SqlClient;

using System;

using System.Collections.Generic;

using System.Data;


namespace DAL

{

    public class clsInternationalLicenseDAL

    {

        public static bool getInternationalLicenseByID(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)

        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try

            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())

                {

                    isFound = true;

                    ApplicationID = (int)reader["ApplicationID"];

                    DriverID = (int)reader["DriverID"];

                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];

                    IssueDate = (DateTime)reader["IssueDate"];

                    ExpirationDate = (DateTime)reader["ExpirationDate"];

                    IsActive = (bool)reader["IsActive"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];


                }

                reader.Close();

            }


            catch (Exception ex) { isFound = false; throw; }


            finally { connection.Close(); }

            return isFound;

        }

        public static bool getInternationalLicenseByDriverID(ref int InternationalLicenseID, ref int ApplicationID, int DriverID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)

        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT * FROM InternationalLicenses WHERE DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try

            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())

                {

                    isFound = true;

                    InternationalLicenseID = (int)reader["InternationalLicenseID"];

                    ApplicationID = (int)reader["ApplicationID"];

                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];

                    IssueDate = (DateTime)reader["IssueDate"];

                    ExpirationDate = (DateTime)reader["ExpirationDate"];

                    IsActive = (bool)reader["IsActive"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];


                }

                reader.Close();

            }


            catch (Exception ex) { isFound = false; throw; }


            finally { connection.Close(); }

            return isFound;

        }

        public static bool updateInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)

        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = @"UPDATE InternationalLicenses SET

                    ApplicationID = @ApplicationID,

                    DriverID = @DriverID,

                    IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,

                    IssueDate = @IssueDate,

                    ExpirationDate = @ExpirationDate,

                    IsActive = @IsActive,

                    CreatedByUserID = @CreatedByUserID WHERE InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue(@"InternationalLicenseID", InternationalLicenseID);

            command.Parameters.AddWithValue(@"ApplicationID", ApplicationID);

            command.Parameters.AddWithValue(@"DriverID", DriverID);

            command.Parameters.AddWithValue(@"IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);

            command.Parameters.AddWithValue(@"IssueDate", IssueDate);

            command.Parameters.AddWithValue(@"ExpirationDate", ExpirationDate);

            command.Parameters.AddWithValue(@"IsActive", IsActive);

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

        public static int addInternationalLicense(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)

        {

            int InternationalLicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = @"INSERT INTO InternationalLicenses (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)

VALUES (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);

SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue(@"ApplicationID", ApplicationID);

            command.Parameters.AddWithValue(@"DriverID", DriverID);

            command.Parameters.AddWithValue(@"IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);

            command.Parameters.AddWithValue(@"IssueDate", IssueDate);

            command.Parameters.AddWithValue(@"ExpirationDate", ExpirationDate);

            command.Parameters.AddWithValue(@"IsActive", IsActive);

            command.Parameters.AddWithValue(@"CreatedByUserID", CreatedByUserID);

            try

            {

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))

                {

                    InternationalLicenseID = insertedID;

                }

            }

            catch (Exception) { }

            finally { connection.Close(); }


            return InternationalLicenseID;

        }

        public static bool deleteInternationalLicense(int InternationalLicenseID)

        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "DELETE FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

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

            string query = "SELECT * FROM InternationalLicenses";

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


        public static DataTable getAllByDriverID(int DriverID)

        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT * FROM InternationalLicenses WHERE DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);


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


        public static bool isInternationalLicenseExistByDriverID(int DriverID)

        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT Found=1 FROM InternationalLicenses WHERE DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);


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


        public static bool isInternationalLicenseExistByID(int InternationalLicenseID)

        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT Found=1 FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);


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








