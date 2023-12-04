using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CargoFlowMgmt
{
    public class Transporter
    {
        private int id;
        private string name;
        private string loadCapacity;

        // Constructor
        public Transporter(int id, string name, string loadCapacity)
        {
            this.id = id;
            this.name = name;
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

        public string LoadCapacity
        {
            get { return loadCapacity; }
        }
    }
}