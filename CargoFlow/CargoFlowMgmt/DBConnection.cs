using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;

namespace CargoFlowMgmt
{
    public class DBConnection
    {
        private MySqlConnection connection;

        public DBConnection()
        {
            InitConnection();
        }

        /// <summary>
        /// Initialize the connection to the database
        /// </summary>
        private void InitConnection()
        {
            // Creation of the connection string : where, who
            string connectionString = "SERVER=localhost; DATABASE=cargoflow; UID=CargoFlow Admin; PASSWORD=Pa$$w0rd";
            //string connectionString = "SERVER=localhost; DATABASE=calculator; UID=root; PASSWORD=P@ssw0rd";
            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Open connection to the database
        /// </summary>
        public void OpenConnection()
        {
            connection.Open();
        }

        /// <summary>
        /// Close connection to the database
        /// </summary>
        public void CloseConnection()
        {
            connection.Dispose();
        }

        /// <summary>
        /// Check if the email exists in the database, then check if the password matches. Throw exception if bad login data.
        /// </summary>
        /// <param name="email">The email to check</param>
        /// <param name="password">The password to check</param>
        public void CheckPassword(string email, string password)
        {
            // Create a SQL command object
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = "SELECT password FROM employees WHERE email = @email";

            // Add parameter to the SQL request
            cmd.Parameters.AddWithValue("@email", email);

            // Execute the SQL command and put its result in a DbDataReader object
            DbDataReader reader = cmd.ExecuteReader();
            reader.Read();

            // If reader has rows, check if it matches the password, else return false
            if (reader.HasRows)
            {
                // If password matches, return true, else return false
                // password column is the first and only column (index 0)
                if (reader.GetString(0) == password)
                {
                    reader.Close();
                }
                else
                {
                    reader.Close();
                    throw new WrongLoginException("Identifiants incorrects.");
                }
            }
            else
            {
                reader.Close();
                throw new EmailNotFoundException("Identifiants incorrects.");
            }
        }

        /// <summary>
        /// Get the role of an employee based on his email
        /// </summary>
        /// <param name="email">The email of the employee</param>
        public string GetEmployeeRole(string email)
        {
            // Create a SQL command object
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = "SELECT role FROM employees WHERE email = @email";

            // Add parameter to the SQL request
            cmd.Parameters.AddWithValue("@email", email);

            // Execute the SQL command and put its result in a DbDataReader object
            DbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string role =  reader.GetString(0);
            reader.Close();
            return role;
        }

        /// <summary>
        /// Get all the records from the database and return them as a 2D string array
        /// </summary>
        /// <param name="query">The text of the SQL request</param>
        /// <returns>A two-dimensional array containing the records</returns>
        public List<string[]> GetAllRecords(string query)
        {
            // Create a SQL command object
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = query;

            // Execute the SQL command and put its result in a DbDataReader object
            DbDataReader reader = cmd.ExecuteReader();

            // Get the number of columns in the result set
            int columnCount = reader.FieldCount;

            // Create a list to store the records
            List<string[]> records = new List<string[]>();

            // Read the result line by line
            while (reader.Read())
            {
                // Create an array to store the values of the current record
                string[] record = new string[columnCount];

                // Get the values of each column in the current record
                for (int i = 0; i < columnCount; i++)
                {
                    if (reader.IsDBNull(i))
                    {
                        // Case when the value to retrieve is null
                        record[i] = null;
                    }
                    else
                    {
                        // Case when the value to retrieve is not null
                        record[i] = reader.GetString(i);
                    }
                }

                // Add the record to the list
                records.Add(record);
            }

            reader.Close();

            return records;
        }

        /// <summary>
        /// Get a record in the database and return it as a 2D string array
        /// </summary>
        /// <param name="query">The text of the SQL request</param>
        /// <param name="id">The id of the record to get</param>
        public string[] GetRecord(string query, int id)
        {
            // Create a SQL command object
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = query;

            // Add parameter to the SQL request
            cmd.Parameters.AddWithValue("@id", id);

            // Execute the SQL command and put its result in a DbDataReader object
            DbDataReader reader = cmd.ExecuteReader();

            // Get the number of columns in the result
            int columnCount = reader.FieldCount;

            // Create an array to store the values of the current record
            string[] recordData = new string[columnCount];

            reader.Read();

            // Get the values of each column in the current record
            for (int i = 0; i < columnCount; i++)
            {
                if (reader.IsDBNull(i))
                {
                    // Case when the value to retrieve is null
                    recordData[i] = null;
                }
                else
                {
                    // Case when the value to retrieve is not null
                    recordData[i] = reader.GetString(i);
                }
            }

            reader.Close();
            return recordData;
        }

        /// <summary>
        /// Add a record in the database
        /// </summary>
        /// <param name="query">The text of the SQL request</param>
        /// <param name="data">The values to add to the SQL request, formatted as key-value associations</param>
        public int AddRecord(string query, Dictionary<string, string?> data)
        {
            // Create a SQL command object
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = query;

            // Add each data key and value to the SQL request
            foreach (KeyValuePair<string, string?> d in data)
            {
                cmd.Parameters.AddWithValue(d.Key, d.Value);
            }

            // Execute the SQL command and return the number of rows affected
            int nbRowsAffected = cmd.ExecuteNonQuery();
            return nbRowsAffected;
        }

        /// <summary>
        /// Update a record in the database
        /// </summary>
        /// <param name="query">The text of the SQL request</param>
        /// <param name="data">The values to add to the SQL request, formatted as key-value associations</param>
        public int UpdateRecord(string query, Dictionary<string, string?> data)
        {
            // Create a SQL command object
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = query;

            // Add each data key and value to the SQL request
            foreach (KeyValuePair<string, string?> d in data)
            {
                cmd.Parameters.AddWithValue(d.Key, d.Value);
            }

            // Execute the SQL command and return the number of rows affected
            int nbRowsAffected = cmd.ExecuteNonQuery();
            return nbRowsAffected;
        }

        /// <summary>
        /// Delete a record in the database
        /// </summary>
        /// <param name="query">The text of the SQL request</param>
        /// <param name="id">The id of the record to delete</param>
        public void DeleteRecord(string query, int id)
        {
            // Create a SQL command object
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = query;

            // Add parameter to the SQL request
            cmd.Parameters.AddWithValue("@id", id);

            // Execute the SQL command
            cmd.ExecuteNonQuery();
        }

        public class WrongLoginException : Exception
        {
            public WrongLoginException(string message) : base(message) { }
        }
        public class EmailNotFoundException : Exception
        {
            public EmailNotFoundException(string message) : base(message) { }
        }
    }
}
