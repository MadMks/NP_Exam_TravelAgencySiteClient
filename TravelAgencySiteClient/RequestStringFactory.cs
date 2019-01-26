using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencySiteClient
{
    class RequestStringFactory
    {
        private string token;

        public RequestStringFactory(string token)
        {
            this.token = token;
        }

        public string Generate(string queryCountries)
        {
            string requestStr = "TODO: " + token;

            return requestStr;
        }

        public string GenerateCountries()
        {
            string requestStr = 
                "token=" + token +
                "&param=" + QueryValue.getCountries;

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
    }
}
