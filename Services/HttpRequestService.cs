using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Test_Task_WPF.Models;

namespace Test_Task_WPF.Services
{
    
    class HttpRequestService
    {
        private HttpClient _httpClient => new HttpClient();
        private string _request;

        public IEnumerable<Coin> GetTopCoins()
        {
            if (StoreValueService.Coins != null)
                return StoreValueService.Coins;
            _request = "https://api.coingecko.com/api/v3/search/trending";
            HttpResponseMessage response = (_httpClient.GetAsync(_request)).Result;

            string responseBody = response.Content.ReadAsStringAsync().Result;
            JObject jObject = JObject.Parse(responseBody);
            JToken list = jObject["coins"];
            StoreValueService.Coins = list.ToObject<IEnumerable<Coin>>();
            return StoreValueService.Coins;
        }
    }
}
