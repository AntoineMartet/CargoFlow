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
        private static DBConnection? dbConn;

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
        /// Get all the clients from the database and return them as a list of Client objects
        /// </summary>
        public static List<CargoFlowMgmt.Client> GetClients()
        {
            List<CargoFlowMgmt.Client> list = new List<CargoFlowMgmt.Client>();
            dbConn = new DBConnection();
            dbConn.OpenConnection();
            string getAllClientsQuery = "SELECT id, lastName, firstName, email, street, streetNumber, city, postalCode FROM clients";
            List<string[]> records = dbConn.GetAllRecords(getAllClientsQuery);

            // Double loop reading records
            foreach (string[] record in records)
            {
                // Preparing the parameters for the Client constructor
                int id = Int32.Parse(record[0]);
                string lastName = record[1];
                string firstName = record[2];
                string email = record[3];
                string street = record[4];
                string streetNumber = record[5];
                string city = record[6];
                string postalCode = record[7];
                // Create the Address object
                Address address = new Address(street, streetNumber, city, postalCode);
                // Create the Client object
                CargoFlowMgmt.Client client = new CargoFlowMgmt.Client(id, lastName, firstName, email, address);
                // Add the Client object to the list
                list.Add(client);
            }
            dbConn.CloseConnection();
            return list;
        }
    }
}