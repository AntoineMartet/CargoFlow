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


        public bool CheckPassword(string email, string password)
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
                if(reader.GetString(0) == password)
                {
                    Console.WriteLine("Password is correct");
                    reader.Close();
                    return true;
                }
                else
                {
                    Console.WriteLine("Password is incorrect");
                    reader.Close();
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Informations rentrées incorrectes");
                reader.Close();
                return false;
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

        public int DeleteCarrier(int id)
        {
            // Create a SQL command object
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = "DELETE FROM carriers WHERE id = @id";

            // Add parameter to the SQL request
            cmd.Parameters.AddWithValue("@id", id);

            // Execute the SQL command
            int nbRowsAffected = cmd.ExecuteNonQuery();

            return nbRowsAffected;
        }

        public int AddCarrier(string name, string tel, string email, int? loadCapacity)
        {
            // Create a SQL command object
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = "INSERT INTO carriers (companyName, loadCapacity, email, phoneNumber) VALUES (@name, @loadCapacity, @email, @tel)";

            // Add parameter to the SQL request
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@tel", tel);
            cmd.Parameters.AddWithValue("@loadCapacity", loadCapacity);

            // Execute the SQL command
            int nbRowsAffected = cmd.ExecuteNonQuery();

            return nbRowsAffected;
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

        /// <summary>
        /// Close connection to the database
        /// </summary>
        public void CloseConnection()
        {
            connection.Dispose();
        }
    }
}
