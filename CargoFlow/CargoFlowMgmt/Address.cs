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

        /// <summary>
        /// Constructor for Address objects
        /// </summary>
        /// <param name="street">Street</param>
        /// <param name="streetNb">Street number</param>
        /// <param name="city">City name</param>
        /// <param name="postalCode">Postal code</param>
        public Address(string street, string streetNb, string city, string postalCode)
        {
            this.street = street;
            this.streetNb = streetNb;
            this.city = city;
            this.postalCode = postalCode;
        }

        /// <summary>
        /// Property of street
        /// </summary>
        public string Street
        {
            get { return street; }
        }

        /// <summary>
        /// Property of streetNb
        /// </summary>
        public string StreetNb
        {
            get { return streetNb; }
        }

        /// <summary>
        /// Property of city
        /// </summary>
        public string City
        {
            get { return city; }
        }

        /// <summary>
        /// Property of postalCode
        /// </summary>
        public string PostalCode
        {
            get { return postalCode; }
        }

        /// <summary>
        /// Create an address string 
        /// </summary>
        /// <returns>Returns the address in a human friendly format</returns>
        public override string ToString()
        {
            string result = Street + " " + StreetNb + ", " + PostalCode + " " + City;
            return result;
        }
    }
}