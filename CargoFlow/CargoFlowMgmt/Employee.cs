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
        private Warehouse? warehouse;
        private static DBConnection? dbConn;

        public Employee(int id, string lastName, string firstName, string email, string phoneNumber, string role, string employeeNumber, Warehouse? warehouse = null)
        {
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.role = role;
            this.employeeNumber = employeeNumber;
            this.warehouse = warehouse;
        }
        
        /// <summary>
        /// Getter for the employee's ID
        /// </summary>
        public int Id
        {
            get { return id; }
        }

        /// <summary>
        /// Getter for the employee's last name
        /// </summary>
        public string LastName
        {
            get { return lastName; }
        }

        /// <summary>
        /// Getter for the employee's first name
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
        }

        /// <summary>
        /// Getter for the employee's email
        /// </summary>
        public string Email
        {
            get { return email; }
        }

        /// <summary>
        /// Getter for the employee's phone number
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
        }

        /// <summary>
        /// Getter for the employee's role
        /// </summary>
        public string Role
        {
            get { return role; }
        }

        /// <summary>
        /// Getter for the employee's number
        /// </summary>
        public string EmployeeNumber
        {
            get { return employeeNumber; }
        }

        /// <summary>
        /// Produce a string containing the employee's details
        /// </summary>
        /// <returns>Return a string containing the employee's details</returns>
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
        /// <returns>Returns a dictionary containing the employee's details</returns>
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
        /// <returns>Returns a list of Employee objects</returns>
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

        /// <summary>
        /// Get all the employees from the database
        /// </summary>
        /// <returns>Return a list of Employee objects</returns>
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