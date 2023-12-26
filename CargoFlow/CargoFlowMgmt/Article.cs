using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CargoFlowMgmt
{
    public class Article
    {
        private int id;
        private BigInteger barcode;
        private string model;
        private string brand;
        private float? weight;
        private float? height;
        private float? length;
        private float? width;
        private float? price;

        public Article(int id, BigInteger barcode, string model, string brand, float? weight = null, float? height = null, float? length = null, float? width = null, float? price = null)
        {
            this.id = id;
            this.barcode = barcode;
            this.model = model;
            this.brand = brand;
            this.weight = weight;
            this.height = height;
            this.length = length;
            this.width = width;
            this.price = price;
        }

        public int Id
        {
            get { return id; }
        }

        public BigInteger Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public float? Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public float? Height
        {
            get { return height; }
            set { height = value; }
        }

        public float? Length
        {
            get { return length; }
            set { length = value; }
        }

        public float? Width
        {
            get { return width; }
            set { width = value; }
        }

        public float? Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}