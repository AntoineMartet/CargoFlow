using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CargoFlowMgmt
{
    public class Address
    {
        private string street;
        private string streetNb;
        private string city;
        private string postalCode;

        // Constructor
        public Address(string street, string streetNb, string city, string postalCode)
        {
            this.street = street;
            this.streetNb = streetNb;
            this.city = city;
            this.postalCode = postalCode;
        }

        // Properties
        public string Street
        {
            get { return street; }
        }

        public string StreetNb
        {
            get { return streetNb; }
        }

        public string City
        {
            get { return city; }
        }

        public string PostalCode
        {
            get { return postalCode; }
        }

        public override string ToString()
        {
            string result = Street + " " + StreetNb + ", " + PostalCode + " " + City;
            return result;
        }
    }
}