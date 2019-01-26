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
        public static string getCities { get; }
        public static string getHotels { get; }

        public QueryValue() {}

        static QueryValue()
        {
            getCountries = "getCountries";
            getCities = "getCities";
            getHotels = "getHotels";
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
