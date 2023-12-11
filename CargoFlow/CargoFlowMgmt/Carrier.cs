using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CargoFlowMgmt
{
    public class Carrier
    {
        private int id;
        private string name;
        private int loadCapacity;

        // Constructor
        public Carrier(int id, string name, int loadCapacity)
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

        public int LoadCapacity
        {
            get { return loadCapacity; }
        }
    }
}