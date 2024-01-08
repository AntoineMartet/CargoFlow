using Org.BouncyCastle.Asn1.TeleTrust;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CargoFlowMgmt
{
    public class Carrier
    {
        private int id;
        private string name;
        private int? loadCapacity;
        private string email;
        private string phoneNumber;
        private static DBConnection? dbConn;

        /// <summary>
        /// Constructor for Carrier objects
        /// </summary>
        /// <param name="id">ID of the carrier</param>
        /// <param name="name">Nam of the carriere</param>
        /// <param name="phoneNumber">Phone number of the carrier</param>
        /// <param name="email">Email of the carrier</param>
        /// <param name="loadCapacity">Load capacity of the carrier</param>
        public Carrier(int id, string name, string phoneNumber, string email, int? loadCapacity = null)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.loadCapacity = loadCapacity;
        }

        /// <summary>
        /// Carrier's ID property
        /// </summary>
        public int Id
        {
            get { return id; }
        }

        /// <summary>
        /// Carrier's name property
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Carrier's phone number property
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
        }

        /// <summary>
        /// Carrier's email property
        /// </summary>
        public string Email
        {
            get { return email; }
        }

        /// <summary>
        /// Carrier's load capacity property
        /// </summary>
        public int? LoadCapacity
        {
            get { return loadCapacity; }
        }

        /// <summary>
        /// Create a string containing the carrier's details
        /// </summary>
        /// <returns>A string containing the carrier's details</returns>
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
        /// Create a dictionary containing the carrier's details
        /// </summary>
        /// <returns>Returns a dictionary containing the carrier's details</returns>
        public Dictionary<string, string?> DetailsTable()
        {
            Dictionary<string, string?> infoTable = new Dictionary<string, string?>();
            infoTable.Add("ID base de données", Id.ToString());
            infoTable.Add("Nom de l'entreprise ", Name);
            infoTable.Add("Téléphone", PhoneNumber);
            infoTable.Add("Email", Email);
            infoTable.Add("Capacité en kg", (LoadCapacity == null) ? null : LoadCapacity.ToString());
            return infoTable;
        }

        /// <summary>
        /// Get all the carriers from the database
        /// </summary>
        /// <returns>A list of Carrier objects</returns>
        public static List<Carrier> GetCarriers()
        {
            List<Carrier> list = new List<Carrier>();
            dbConn = new DBConnection();
            dbConn.OpenConnection();
            string getAllCarriersQuery = "SELECT id, companyName, loadCapacity, email, phoneNumber FROM carriers";
            List<string[]> records = dbConn.GetAllRecords(getAllCarriersQuery);

            // Double loop reading records
            foreach (string[] record in records)
            {
                // Preparing the parameters for the Carrier constructor
                int id = Int32.Parse(record[0]);
                string name = record[1];
                // If the value is null, we set it to null, else we set it to the value retrieved from the database
                int? capacity;
                if (record[2] == null)
                {
                    capacity = null;
                }
                else
                {
                    capacity = Int32.Parse(record[2]);
                }
                string email = record[3];
                string phoneNumber = record[4];
                // Create the Carrier object
                Carrier carrier = new Carrier(id, name, phoneNumber, email, capacity);
                // Add the Carrier object to the list
                list.Add(carrier);
            }
            dbConn.CloseConnection();
            return list;
        }
    }
}