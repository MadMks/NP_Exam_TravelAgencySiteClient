using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TravelAgencySiteClient
{
    class ApiTravelAgency
    {
        private const string TOKEN = "ps_rpo_1";
        private RequestStringFactory requestFactory = null;

        public ApiTravelAgency()
        {
            requestFactory = new RequestStringFactory(TOKEN);

            // TODO: настройки для класса Апи.
        }


        //
        // Методы загрузки сущностей.
        //

        public async Task<string> LoadCountriesDataAsync()
        {
            string request = requestFactory.GenerateCountries();

            string responseJson = await LoadDataAsync(request);

            return responseJson;
        }

        public async Task<string> LoadCitiesDataAsync(string country)
        {
            string request = requestFactory.GenerateCities(country);

            string responseJson = await LoadDataAsync(request);

            return responseJson;
        }

        public async Task<string> LoadAllCitiesDataAsync()
        {
            string request = requestFactory.GenerateAllCities();

            string responseJson = await LoadDataAsync(request);

            return responseJson;
        }

        public async Task<string> LoadHotelsDataAsync(string country, string city)
        {
            string request = requestFactory.GenerateHotels(country, city);

            string responseJson = await LoadDataAsync(request);

            return responseJson;
        }

        //
        // Методы записи данных.
        //

        public async Task<string> UserRegistrationAsync(string login, string pass, string email)
        {
            string request = requestFactory.GenerateRegUser(login, pass, email);

            string responseJson = await LoadDataAsync(request);

            return responseJson;
        }

        public async Task<string> AddCountryAsync(string country)
        {
            string obj = JsonConvert.SerializeObject(new Country(country));

            string request = requestFactory.GenerateAddCountry(obj);

            return await LoadDataAsync(request);
        }

        //
        // Загрузка данных.
        //

        private async Task<string> LoadDataAsync(string requestStr)
        {
            WebRequest request = WebRequest
                .Create("http://localhost:81/apiExem/api.php");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";


            byte[] data = Encoding.UTF8.GetBytes(requestStr);

            request.ContentLength = data.Length;

            // Записываем данные в поток запроса.
            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }


            // Считываем ответ.
            WebResponse response = await request.GetResponseAsync();
            string responseStr = null;
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    responseStr = reader.ReadToEnd();
                }
            }
            response.Close();

            return responseStr;
        }

        
    }
}
