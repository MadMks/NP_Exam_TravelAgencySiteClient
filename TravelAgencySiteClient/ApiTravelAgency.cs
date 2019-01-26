﻿using System;
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
        private RequestStringFactory requestFactory = null;

        public ApiTravelAgency()
        {
            requestFactory = new RequestStringFactory("ps_rpo_1");

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


        //
        // Загрузка данных.
        //

        private async Task<string> LoadDataAsync(/*string param, string value*/string requestStr)
        {
            WebRequest request = WebRequest
                .Create("http://localhost:81/apiExem/api.php");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            //string requestStr = "token=ps_rpo_1" +
            //    "&param=" + param;
            //if (value != null)
            //{
            //    requestStr = requestStr + value;
            //}

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
