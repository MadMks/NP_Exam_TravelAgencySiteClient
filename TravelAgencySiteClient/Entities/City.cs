﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencySiteClient
{
    public class City
    {
        public int id { get; set; }
        public string cityName { get; set; }
        public string countryName { get; set; }

        public City(string country, string city)
        {
            countryName = country;
            cityName = city;
        }
    }
}
