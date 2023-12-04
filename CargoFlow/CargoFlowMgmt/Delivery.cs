using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CargoFlowMgmt
{
    public class Delivery
    {
        private int id;
        private int barcode;
        private DateTime startDate;
        private DateTime endDate;
        private Address originAddress;
        private Address destinationAddress;
        private List<Article> articles;

        // Constructor
        public Delivery(int id, int barcode, DateTime startDate, DateTime endDate, Address originAddress, Address destinationAddress, List<Article> articles)
        {
            this.id = id;
            this.barcode = barcode;
            this.startDate = startDate;
            this.endDate = endDate;
            this.originAddress = originAddress;
            this.destinationAddress = destinationAddress;
            this.articles = new List<Article>();
        }

        // Properties
        public int Id
        {
            get { return id; }
        }

        public int Barcode
        {
            get { return barcode; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
        }

        public Address OriginAddress
        {
            get { return originAddress; }
        }

        public Address DestinationAddress
        {
            get { return destinationAddress; }
        }

        public List<Article> Articles
        {
            get { return articles; }
        }
    }
}