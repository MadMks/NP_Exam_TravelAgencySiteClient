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
        public static string getAllHotels { get; }
        public static string regUser { get; }
        public static string addCountry { get; }
        public static string addCity { get; }
        public static string addHotel { get; }
        public static string delCountry { get; }
        public static string delCity { get; }

        public QueryValue() {}

        static QueryValue()
        {
            getCountries = "getCountries";
            getAllCountries = "getAllCountries";
            getCities = "getCities";
            getAllCities = "getAllCities";
            getHotels = "getHotels";
            getAllHotels = "getAllHotels";
            regUser = "regUser";
            addCountry = "addCountry";
            addCity = "addCity";
            addHotel = "addHotel";
            delCountry = "delCountry";
            delCity = "delCity";
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
