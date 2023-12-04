using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CargoFlowMgmt
{
    public class Warehouse
    {
        private int id;
        private string name;
        private string street;
        private string streetNB;
        private string city;
        private string postalCode;
        private OpeningHours openingHours;
        private List<Article> articles;

        public Warehouse(int id, string name, string street, string streetNB, string city, string postalCode, OpeningHours openingHours, List<Article> articles)
        {
            this.id = id;
            this.name = name;
            this.street = street;
            this.streetNB = streetNB;
            this.city = city;
            this.postalCode = postalCode;
            this.openingHours = openingHours;
            this.openingHours = openingHours;
            this.articles = new List<Article>();
        }

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public string Street
        {
            get { return street; }
        }

        public string StreetNB
        {
            get { return streetNB; }
        }

        public string City
        {
            get { return city; }
        }

        public string PostalCode
        {
            get { return postalCode; }
        }

        public OpeningHours OpeningHours
        {
            get { return openingHours; }
        }

        public List<Article> Articles
        {
            get { return articles; }
        }
    }
}