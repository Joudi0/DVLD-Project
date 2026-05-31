
using Microsoft.Data.SqlClient;

using System;

using System.Collections.Generic;

using System.Data;


namespace DAL

{

    public class clsDetainedLicenseDAL

    {

        public static bool getDetainedLicenseByID(int DetainID, ref int LicenseID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)

        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);

            try

            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())

                {

                    isFound = true;

                    LicenseID = (int)reader["LicenseID"];

                    DetainDate = (DateTime)reader["DetainDate"];

                    FineFees = (decimal)reader["FineFees"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    IsReleased = (bool)reader["IsReleased"];

                    ReleaseDate = (reader["ReleaseDate"] == DBNull.Value) ? DateTime.Now : (DateTime)reader["ReleaseDate"];

                    ReleasedByUserID = (reader["ReleasedByUserID"] == DBNull.Value) ? -1 : (int)reader["ReleasedByUserID"];

                    ReleaseApplicationID = (reader["ReleaseApplicationID"] == DBNull.Value) ? -1 : (int)reader["ReleaseApplicationID"];


                }

                reader.Close();

            }


            catch (Exception ex) { isFound = false; throw; }


            finally { connection.Close(); }

            return isFound;

        }

        public static bool getDetainedLicenseByLicenseID(ref int DetainID, int LicenseID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)

        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try

            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())

                {

                    isFound = true;

                    DetainID = (int)reader["DetainID"];

                    DetainDate = (DateTime)reader["DetainDate"];

                    FineFees = (decimal)reader["FineFees"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    IsReleased = (bool)reader["IsReleased"];

                    ReleaseDate = (reader["ReleaseDate"] == DBNull.Value) ? DateTime.Now : (DateTime)reader["ReleaseDate"];

                    ReleasedByUserID = (reader["ReleasedByUserID"] == DBNull.Value) ? -1 : (int)reader["ReleasedByUserID"];

                    ReleaseApplicationID = (reader["ReleaseApplicationID"] == DBNull.Value) ? -1 : (int)reader["ReleaseApplicationID"];


                }

                reader.Close();

            }


            catch (Exception ex) { isFound = false; throw; }


            finally { connection.Close(); }

            return isFound;

        }

        public static bool updateDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)

        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = @"UPDATE DetainedLicenses SET

                    LicenseID = @LicenseID,

                    DetainDate = @DetainDate,

                    FineFees = @FineFees,

                    CreatedByUserID = @CreatedByUserID,

                    IsReleased = @IsReleased,

                    ReleaseDate = @ReleaseDate,

                    ReleasedByUserID = @ReleasedByUserID,

                    ReleaseApplicationID = @ReleaseApplicationID WHERE DetainID = @DetainID;";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue(@"DetainID", DetainID);

            command.Parameters.AddWithValue(@"LicenseID", LicenseID);

            command.Parameters.AddWithValue(@"DetainDate", DetainDate);

            command.Parameters.AddWithValue(@"FineFees", FineFees);

            command.Parameters.AddWithValue(@"CreatedByUserID", CreatedByUserID);

            command.Parameters.AddWithValue(@"IsReleased", IsReleased);

            command.Parameters.AddWithValue(@"ReleaseDate", (ReleaseDate == DateTime.MinValue) ? DBNull.Value : (object)ReleaseDate);

            command.Parameters.AddWithValue(@"ReleasedByUserID", (ReleasedByUserID == -1) ? DBNull.Value : (object)ReleasedByUserID);

            command.Parameters.AddWithValue(@"ReleaseApplicationID", (ReleaseApplicationID == -1) ? DBNull.Value : (object)ReleaseApplicationID);

            try

            {

                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }

            catch (Exception) { return false; }

            finally { connection.Close(); }


            return (rowsAffected > 0);

        }

        public static int addDetainedLicense(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)

        {

            int DetainedLicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = @"INSERT INTO DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID)

VALUES (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID);

SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue(@"LicenseID", LicenseID);

            command.Parameters.AddWithValue(@"DetainDate", DetainDate);

            command.Parameters.AddWithValue(@"FineFees", FineFees);

            command.Parameters.AddWithValue(@"CreatedByUserID", CreatedByUserID);

            command.Parameters.AddWithValue(@"IsReleased", IsReleased);

            command.Parameters.AddWithValue(@"ReleaseDate", (ReleaseDate == DateTime.MinValue) ? DBNull.Value : (object)ReleaseDate);

            command.Parameters.AddWithValue(@"ReleasedByUserID", (ReleasedByUserID == -1) ? DBNull.Value : (object)ReleasedByUserID);

            command.Parameters.AddWithValue(@"ReleaseApplicationID", (ReleaseApplicationID == -1) ? DBNull.Value : (object)ReleaseApplicationID);

            try

            {

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))

                {

                    DetainedLicenseID = insertedID;

                }

            }

            catch (Exception) { }

            finally { connection.Close(); }


            return DetainedLicenseID;

        }

        public static bool deleteDetainedLicense(int DetainID)

        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "DELETE FROM DetainedLicenses WHERE DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);

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

            string query = "SELECT * FROM DetainedLicenses";

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


        public static DataTable getAllByLicenseID(int LicenseID)

        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


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


        public static bool isDetainedLicenseExistByLicenseID(int LicenseID)

        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT Found=1 FROM DetainedLicenses WHERE LicenseID = @LicenseID";

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


        public static bool isDetainedLicenseExistByID(int DetainID)

        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);

            string query = "SELECT Found=1 FROM DetainedLicenses WHERE DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);


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