using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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

        public void DeleteCarrier(int id)
        {
            // Create a SQL command object
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = "DELETE FROM carriers WHERE id = @id";

            // Add parameter to the SQL request
            cmd.Parameters.AddWithValue("@id", id);

            // Execute the SQL command
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Add a record in the database
        /// </summary>
        public int Add(string query, Dictionary<string, string?> data)
        {
            try
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Carrier> GetAllCarriers()
        {
            List<Carrier> carriers = new List<Carrier>();

            // Create a SQL command object
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = "SELECT id, companyName, loadCapacity, email, phoneNumber FROM carriers";

            // Execute the SQL command and put its result in a DbDataReader object
            DbDataReader reader = cmd.ExecuteReader();

            // Read the result line by line, creating a Carrier object for each line
            while (reader.Read())
            {
                // Preparing the parameters for the Carrier constructor
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                // GetInt32() doesn't accept null values
                // If the value is null, we set it to null, else we set it to the value
                int? capacity = reader.IsDBNull(2) ? null : reader.GetInt32(2);
                string email = reader.GetString(3);
                string phoneNumber = reader.GetString(4);
                // Create the Carrier object
                Carrier carrier = new Carrier(id, name, phoneNumber, email, capacity);
                // Add the Carrier object to the list
                carriers.Add(carrier);
            }

            reader.Close();
            return carriers;
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
