﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencySiteClient
{
    public class Country
    {
        public int id { get; set; }
        public string countryName { get; set; }

        public Country(string country)
        {
            countryName = country;
        }
    }
}
