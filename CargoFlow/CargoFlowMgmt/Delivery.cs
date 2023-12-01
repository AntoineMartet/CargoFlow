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
    }
}