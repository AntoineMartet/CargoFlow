using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CargoFlowMgmt
{
    public class Delivery
    {
        private int id;
        private BigInteger barcode;
        private DateTime startDate;
        private DateTime endDate;
        private string status;
        private List<Article> articles;

        // Constructor
        public Delivery(int id, BigInteger barcode, DateTime startDate, DateTime endDate, string status, List<Article> articles)
        {
            this.id = id;
            this.barcode = barcode;
            this.startDate = startDate;
            this.endDate = endDate;
            this.status = status;
            this.articles = new List<Article>();
        }

        // Properties
        public int Id
        {
            get { return id; }
        }

        public BigInteger Barcode
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

        public string Status
        {
            get { return status; }
        }

        public List<Article> Articles
        {
            get { return articles; }
        }
    }
}