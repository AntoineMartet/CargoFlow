using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CargoFlowMgmt
{
    public class Client
    {
        private int id;
        private string lastName;
        private string firstName;
        private string email;
        private Address address;

        // Constructor
        public Client(int id, string lastName, string firstName, string email, Address address)
        {
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.email = email;
            this.address = address;
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

        public Address Address
        {
            get { return address; }
        }
    }
}