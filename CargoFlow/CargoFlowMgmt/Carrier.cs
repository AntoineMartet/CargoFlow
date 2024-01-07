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

        // Constructor
        public Carrier(int id, string name, string phoneNumber, string email, int? loadCapacity = null)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.loadCapacity = loadCapacity;
        }

        // Properties
        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
        }

        public string Email
        {
            get { return email; }
        }

        public int? LoadCapacity
        {
            get { return loadCapacity; }
        }

        /// <summary>
        /// Returns a string containing the carrier's details
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
        /// Returns a dictionary containing the carrier's details
        /// </summary>
        /// <returns></returns>
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
    }
}