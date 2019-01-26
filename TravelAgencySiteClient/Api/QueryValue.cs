using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencySiteClient
{
    class QueryValue
    {
        public static string getCountries { get; set; }
        public static string getCities { get; set; }

        public QueryValue() {}

        static QueryValue()
        {
            getCountries = "getCountries";
            getCities = "getCities";
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
