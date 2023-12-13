using System;
using System.Collections.Generic;
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
            return role;
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
