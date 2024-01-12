using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CargoFlowMgmt
{
    public class Employee
    {
        private int id;
        private string lastName;
        private string firstName;
        private string email;
        private string phoneNumber;
        private string role;
        private string employeeNumber;
        private static DBConnection? dbConn;

        public Employee(int id, string lastName, string firstName, string email, string phoneNumber, string role, string employeeNumber)
        {
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.role = role;
            this.employeeNumber = employeeNumber;
        }
        
        // Properties
        public int Id
        {
            get { return id; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public string FirstName
        {
            get { return firstName; }
        }

        public string Email
        {
            get { return email; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
        }

        public string Role
        {
            get { return role; }
        }

        public string EmployeeNumber
        {
            get { return employeeNumber; }
        }

        /// <summary>
        /// Returns a string containing the employee's details
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = "";

            foreach (KeyValuePair<string, string?> entry in DetailsTable())
            {
                result += entry.Key + " : " + entry.Value + "\n\n";
            }

            return result;
        }

        /// <summary>
        /// Returns a dictionary containing the employee's details
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string?> DetailsTable()
        {
            Dictionary<string, string?> infoTable = new Dictionary<string, string?>();
            infoTable.Add("ID base de données", Id.ToString());
            infoTable.Add("Nom", LastName);
            infoTable.Add("Prénom", FirstName);
            infoTable.Add("Email", Email);
            infoTable.Add("Numéro de téléphone", PhoneNumber);
            infoTable.Add("Rôle", Role);
            infoTable.Add("Numéro de l'employé·e", EmployeeNumber);
            return infoTable;
        }

        /// <summary>
        /// Get all the employees from the database and return them as a list of Employee objects
        /// </summary>
        public static List<Employee> GetEmployees()
        {
            List<Employee> list = new List<Employee>();
            dbConn = new DBConnection();
            dbConn.OpenConnection();
            string getAllEmployeesQuery = "SELECT id, lastName, firstName, email, phoneNumber, role, employeeNumber FROM employees";
            List<string[]> records = dbConn.GetRecords(getAllEmployeesQuery);

            // Double loop reading records
            foreach (string[] record in records)
            {
                // Preparing the parameters for the Client constructor
                int id = Int32.Parse(record[0]);
                string lastName = record[1];
                string firstName = record[2];
                string email = record[3];
                string phoneNumber = record[4];
                string role = record[5];
                string employeeNumber = record[6];
                // Create the Employee object
                Employee employee = new Employee(id, lastName, firstName, email, phoneNumber, role, employeeNumber);
                // Add the Employee object to the list
                list.Add(employee);
            }
            dbConn.CloseConnection();
            return list;
        }

        public static List<string[]> GetAllRoles()
        {
            // Open connection to the database
            dbConn = new DBConnection();
            dbConn.OpenConnection();

            // Prepare the SQL request
            string roleQuery = "SELECT DISTINCT role FROM employees";

            // Execute the SQL request
            List<string[]> rolesList = dbConn.GetRecords(roleQuery);

            // Close connection to the database
            dbConn.CloseConnection();

            return rolesList;
        }
    }
}