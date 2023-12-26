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
    }
}