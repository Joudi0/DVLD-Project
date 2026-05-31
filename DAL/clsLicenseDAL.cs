
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace DAL
{
    public class clsLicenseDAL
    {
        public static bool getLicenseByID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try

            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())

                {

                    isFound = true;

                    ApplicationID = (int)reader["ApplicationID"];

                    DriverID = (int)reader["DriverID"];

                    LicenseClass = (int)reader["LicenseClass"];

                    IssueDate = (DateTime)reader["IssueDate"];

                    ExpirationDate = (DateTime)reader["ExpirationDate"];

                    Notes = (reader["Notes"] == DBNull.Value) ? "" : (string)reader["Notes"];

                    PaidFees = (decimal)reader["PaidFees"];

                    IsActive = (bool)reader["IsActive"];

                    IssueReason = (byte)reader["IssueReason"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];


                }

                reader.Close();

            }


            catch (Exception ex) { isFound = false; throw; }


            finally { connection.Close(); }

            return isFound;

        }

        public static bool getLicenseByDriverAndClassID(ref int LicenseID, ref int ApplicationID, int DriverID, int LicenseClassID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)

        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT * FROM Licenses WHERE DriverID = @DriverID AND LicenseClass = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try

            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())

                {

                    isFound = true;

                    LicenseID = (int)reader["LicenseID"];

                    ApplicationID = (int)reader["ApplicationID"];

                    IssueDate = (DateTime)reader["IssueDate"];

                    ExpirationDate = (DateTime)reader["ExpirationDate"];

                    Notes = (reader["Notes"] == DBNull.Value) ? "" : (string)reader["Notes"];

                    PaidFees = (decimal)reader["PaidFees"];

                    IsActive = (bool)reader["IsActive"];

                    IssueReason = (byte)reader["IssueReason"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];


                }

                reader.Close();

            }


            catch (Exception ex) { isFound = false; throw; }


            finally { connection.Close(); }

            return isFound;

        }

        public static bool isLicenseExistByDriverAndClassID(int DriverID, int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT Found=1 FROM Licenses WHERE DriverID = @DriverID AND LicenseClass = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


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

        public static bool updateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)

        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = @"UPDATE Licenses SET

                    ApplicationID = @ApplicationID,

                    DriverID = @DriverID,

                    LicenseClass = @LicenseClass,

                    IssueDate = @IssueDate,

                    ExpirationDate = @ExpirationDate,

                    Notes = @Notes,

                    PaidFees = @PaidFees,

                    IsActive = @IsActive,

                    IssueReason = @IssueReason,

                    CreatedByUserID = @CreatedByUserID WHERE LicenseID = @LicenseID;";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue(@"LicenseID", LicenseID);

            command.Parameters.AddWithValue(@"ApplicationID", ApplicationID);

            command.Parameters.AddWithValue(@"DriverID", DriverID);

            command.Parameters.AddWithValue(@"LicenseClass", LicenseClass);

            command.Parameters.AddWithValue(@"IssueDate", IssueDate);

            command.Parameters.AddWithValue(@"ExpirationDate", ExpirationDate);

            command.Parameters.AddWithValue(@"Notes", string.IsNullOrEmpty(Notes) ? DBNull.Value : (object)Notes);

            command.Parameters.AddWithValue(@"PaidFees", PaidFees);

            command.Parameters.AddWithValue(@"IsActive", IsActive);

            command.Parameters.AddWithValue(@"IssueReason", IssueReason);

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

        public static int addLicense(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)

        {

            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = @"INSERT INTO Licenses (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)

VALUES (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);

SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue(@"ApplicationID", ApplicationID);

            command.Parameters.AddWithValue(@"DriverID", DriverID);

            command.Parameters.AddWithValue(@"LicenseClass", LicenseClass);

            command.Parameters.AddWithValue(@"IssueDate", IssueDate);

            command.Parameters.AddWithValue(@"ExpirationDate", ExpirationDate);

            command.Parameters.AddWithValue(@"Notes", string.IsNullOrEmpty(Notes) ? DBNull.Value : (object)Notes);

            command.Parameters.AddWithValue(@"PaidFees", PaidFees);

            command.Parameters.AddWithValue(@"IsActive", IsActive);

            command.Parameters.AddWithValue(@"IssueReason", IssueReason);

            command.Parameters.AddWithValue(@"CreatedByUserID", CreatedByUserID);

            try

            {

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))

                {

                    LicenseID = insertedID;

                }

            }

            catch (Exception) { }

            finally { connection.Close(); }


            return LicenseID;

        }

        public static bool deleteLicense(int LicenseID)

        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "DELETE FROM Licenses WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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

            string query = "SELECT * FROM Licenses";

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

            string query = "SELECT * FROM Licenses WHERE DriverID = @DriverID";

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


        public static bool isLicenseExistByID(int LicenseID)

        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT Found=1 FROM Licenses WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


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


