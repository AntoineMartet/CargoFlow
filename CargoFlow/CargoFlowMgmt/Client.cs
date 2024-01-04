using Org.BouncyCastle.Asn1.TeleTrust;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

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

        /// <summary>
        /// Returns a dictionary containing the client's details
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string?> DetailsTable()
        {
            Dictionary<string, string?> infoTable = new Dictionary<string, string?>();
            infoTable.Add("ID base de données", Id.ToString());
            infoTable.Add("Nom", LastName);
            infoTable.Add("Prénom", FirstName);
            infoTable.Add("Email", Email);
            infoTable.Add("Adresse", Address.ToString());
            return infoTable;
        }

        /// <summary>
        /// Returns a string containing the client's details
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
    }
}