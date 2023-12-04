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
        private string mail;
        private string role;
        private int employeeNumber;

        public Employee(int id, string lastName, string firstName, string mail, string role, int employeeNumber)
        {
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.mail = mail;
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

        public string Mail
        {
            get { return mail; }
        }

        public string Role
        {
            get { return role; }
        }

        public int EmployeeNumber
        {
            get { return employeeNumber; }
        }
    }
}