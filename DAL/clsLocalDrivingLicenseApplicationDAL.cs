using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class clsLocalDrivingLicenseApplicationDAL
    {
        public static bool getLocalDrivingLicenseApplicationByID(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;


            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);


            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";


            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try


            {


                connection.Open();


                SqlDataReader reader = command.ExecuteReader();



                if (reader.Read())
                {


                    isFound = true;


                    ApplicationID = (int)reader["ApplicationID"];


                    LicenseClassID = (int)reader["LicenseClassID"];



                }


                reader.Close();


            }



            catch (Exception ex) { isFound = false; throw; }



            finally { connection.Close(); }


            return isFound;


        }


        public static bool updateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)


        {


            int rowsAffected = 0;


            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);


            string query = @"UPDATE LocalDrivingLicenseApplications SET


                    ApplicationID = @ApplicationID,


                    LicenseClassID = @LicenseClassID WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";


            SqlCommand command = new SqlCommand(query, connection);



            command.Parameters.AddWithValue(@"LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            command.Parameters.AddWithValue(@"ApplicationID", ApplicationID);


            command.Parameters.AddWithValue(@"LicenseClassID", LicenseClassID);


            try


            {


                connection.Open();


                rowsAffected = command.ExecuteNonQuery();


            }


            catch (Exception) { return false; }


            finally { connection.Close(); }



            return (rowsAffected > 0);


        }


        public static int addLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)


        {


            int PersonID = -1;


            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);


            string query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)


VALUES (@ApplicationID, @LicenseClassID);


SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);



            command.Parameters.AddWithValue(@"ApplicationID", ApplicationID);


            command.Parameters.AddWithValue(@"LicenseClassID", LicenseClassID);


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


        public static bool deleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            int rowsAffected = 0;


            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);


            string queryDeleteLicenseApp = "DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            string queryDeleteAppointments = "DELETE FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            string queryDeleteTest = "DELETE FROM Tests WHERE TestAppointmentID in (SELECT TestAppointmentID FROM TestAppointments WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)";


            SqlCommand commandDeleteLicenseApp = new SqlCommand(queryDeleteLicenseApp, connection);
            SqlCommand commandDeleteAppointments = new SqlCommand(queryDeleteAppointments, connection);
            SqlCommand commandDeleteTest = new SqlCommand(queryDeleteTest, connection);

            commandDeleteLicenseApp.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            commandDeleteAppointments.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            commandDeleteTest.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {


                connection.Open();

                commandDeleteTest.ExecuteNonQuery();
                commandDeleteAppointments.ExecuteNonQuery();
                rowsAffected = commandDeleteLicenseApp.ExecuteNonQuery();



            }


            catch (Exception) { throw; }


            finally { connection.Close(); }


            return (rowsAffected > 0);
        }

        public static int lastTestAppointmentID(int ldlaID, int testTypeID)

        {

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);


            string query = "SELECT TOP 1 TestAppointmentID FROM TestAppointments WHERE TestAppointments.LocalDrivingLicenseApplicationID = @ldlaID AND TestAppointments.TestTypeID = @testTypeID ORDER BY AppointmentDate DESC;";


            int lastID = -1;


            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ldlaID", ldlaID);

            command.Parameters.AddWithValue("@testTypeID", testTypeID);


            try


            {


                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int count))

                {

                    lastID = count;

                }


            }



            catch (Exception ex) { throw; }



            finally { connection.Close(); }


            return lastID;





        }


        public static int getTrialsByAppAndTestID(int ID, int testTypeID)

        {

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);


            string query = $"SELECT COUNT(*) AS trials FROM LocalDrivingLicenseApplications JOIN TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @ID AND TestResult = 0 AND TestAppointments.TestTypeID = @testTypeID;";

            int trials = -1;

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ID", ID);

            command.Parameters.AddWithValue("@testTypeID", testTypeID);


            try

            {

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int count))

                {

                    trials = count;

                }

            }



            catch (Exception ex) { throw; }



            finally { connection.Close(); }


            return trials;


        }



        public static DataTable getAll()


        {


            DataTable dt = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);


            string query = "SELECT * FROM LocalDrivingLicenseApplications";


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


        public static DataTable getAllView()

        {

            DataTable dt = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);


            string query = "SELECT * FROM LocalDrivingLicenseApplications_View";


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


        public static int examsPassedByID(int id)

        {

            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);


            string query = "SELECT PassedTestCount FROM LocalDrivingLicenseApplications_View WHERE LocalDrivingLicenseApplicationID = @id";


            int passed = -1;


            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@id", id);


            try


            {


                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int count))

                {

                    passed = count;

                }


            }



            catch (Exception ex) { throw; }



            finally { connection.Close(); }


            return passed;





        }


        public static bool isLocalDrivingLicenseApplicationExistByID(int LocalDrivingLicenseApplicationID)


        {


            bool isFound = false;


            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);


            string query = "SELECT Found=1 FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";


            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);



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


        public static bool isLocalDrivingLicenseApplicationExistByPersonIDAndClassID(int PersonID, int licenseClassID)

        {


            bool isFound = false;


            SqlConnection connection = new SqlConnection(clsDataSettings.connectionString);


            string query = "SELECT Found=1 FROM LocalDrivingLicenseApplications JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID WHERE Applications.ApplicantPersonID = @PersonID AND LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID AND Status = New";


            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@PersonID", PersonID);

            command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

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