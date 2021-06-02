using GoogleTimeZoneAPI.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GoogleTimeZoneAPI.API
{
    public class GoogleAPI : IGoogleAPI
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public GoogleAPI(IHttpClientFactory httpClientFactory, IConfiguration config)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = config;
        }


        public async Task<ResponseModel> GetLocationTimeStamp(string location, string timestamp)
        {
            ResponseModel googleModel;
            string key = _configuration.GetValue<string>("APIKey");

            try
            {
                string url = string.Format("?location={0}&timestamp={1}&key={2}", location, timestamp, key);
                var client = _httpClientFactory.CreateClient("GoogleAPIURL");
                googleModel = await client.GetFromJsonAsync<ResponseModel>(url);
            }
            catch (Exception ex)
            {
                googleModel = new ResponseModel() { errorMessage = string.Format("There was an error getting Google Time Zone API : {0}", ex.ToString()) };
            }

            return googleModel;
        }
    }
}
