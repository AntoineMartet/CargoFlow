﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CargoFlowMgmt
{
    public class OpeningHours
    {
        string[,] openingHours = new string[7, 2];

        public OpeningHours(string[,] openingHours)
        {
            this.openingHours = openingHours;
        }
    }
}