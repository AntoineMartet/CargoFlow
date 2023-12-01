﻿using System;
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
    }
}