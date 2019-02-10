using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencySiteClient
{
    class QueryValue
    {
        public static string getCountries { get; }
        public static string getAllCountries { get; }
        public static string getCities { get; }
        public static string getAllCities { get; }
        public static string getHotels { get; }
        public static string regUser { get; }
        public static string addCountry { get; }

        public QueryValue() {}

        static QueryValue()
        {
            getCountries = "getCountries";
            getAllCountries = "getAllCountries";
            getCities = "getCities";
            getAllCities = "getAllCities";
            getHotels = "getHotels";
            regUser = "regUser";
            addCountry = "addCountry";
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
