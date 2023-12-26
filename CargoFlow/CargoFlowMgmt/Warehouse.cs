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
        private Address address;
        private OpeningHours openingHours;
        private List<Article> articles;

        public Warehouse(int id, string name, Address address, OpeningHours openingHours, List<Article> articles)
        {
            this.id = id;
            this.name = name;
            this.address = address;
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

        public Address Address
        {
            get { return address; }
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