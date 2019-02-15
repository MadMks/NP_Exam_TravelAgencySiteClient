using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencySiteClient
{
    class RequestStringFactory
    {
        private string token = null;

        public RequestStringFactory(string token)
        {
            this.token = token;
        }

        //public string Generate(string queryCountries)
        //{
        //    string requestStr = "TODO: " + token;

        //    return requestStr;
        //}

        public string GenerateCountries()
        {
            string requestStr = 
                "token=" + token +
                "&param=" + QueryValue.getCountries;

            return requestStr;
        }

        internal string GenerateAllCountries()
        {
            string requestStr =
                "token=" + token +
                "&param=" + QueryValue.getAllCountries;

            return requestStr;
        }

        public string GenerateCities(string country)
        {
            string requestStr =
                "token=" + token +
                "&param=" + QueryValue.getCities +
                "&country=" + country;

            return requestStr;
        }

        public string GenerateAllCities()
        {
            string requestStr =
                "token=" + token +
                "&param=" + QueryValue.getAllCities;

            return requestStr;
        }

        public string GenerateHotels(string country, string city)
        {
            string requestStr =
                "token=" + token +
                "&param=" + QueryValue.getHotels +
                "&country=" + country +
                "&city=" + city;

            return requestStr;
        }

        public string GenerateAllHotels()
        {
            string requestStr =
                "token=" + token +
                "&param=" + QueryValue.getAllHotels;

            return requestStr;
        }

        internal string GenerateRegUser(string login, string pass, string email)
        {
            string requestStr =
                "token=" + token +
                "&param=" + QueryValue.regUser +
                "&login=" + login +
                "&pass=" + pass +
                "&email=" + email;

            return requestStr;
        }

        internal string GenerateAddCountry(string obj)
        {
            string requestStr =
                "token=" + token +
                "&param=" + QueryValue.addCountry +
                "&object=" + obj;

            return requestStr;
        }

        public string GenerateAddCity(string obj)
        {
            string requestStr =
                "token=" + token +
                "&param=" + QueryValue.addCity +
                "&object=" + obj;

            return requestStr;
        }

        public string GenerateAddHotel(string obj)
        {
            string requestStr =
                "token=" + token +
                "&param=" + QueryValue.addHotel +
                "&object=" + obj;

            return requestStr;
        }

        public string GenerateDelCountry(string countryId)
        {
            string requestStr =
                "token=" + token +
                "&param=" + QueryValue.delCountry +
                "&countryId=" + countryId;

            return requestStr;
        }
    }
}
