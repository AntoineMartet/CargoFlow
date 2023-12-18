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
    }
}