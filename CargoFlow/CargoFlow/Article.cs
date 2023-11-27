using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CargoFlow
{
    public class Article
    {
        private string manufacturerCode;
        private int barCode;
        private string brand;
        private string model;
        private float weight;
        private float height;
        private float width;
        private float price;
        private int id;
        private string category;

        public string ManufacturerCode
        {
            get { return manufacturerCode; }
            set { manufacturerCode = value; }
        }

        public int BarCode
        {
            get { return barCode; }
            set { barCode = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

    }
}