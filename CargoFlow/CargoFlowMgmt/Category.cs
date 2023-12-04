using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CargoFlowMgmt
{
    public class Category
    {
        private int id;
        private string name;
        private string? description;

        public Category (int id, string name, string? description = null)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public string? Description
        {
            get { return description; }
            set { description = value;}
        }
    }
}