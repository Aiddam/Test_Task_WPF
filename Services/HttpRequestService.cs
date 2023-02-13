using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Xml.Linq;
using Test_Task_WPF.Models;
using Test_Task_WPF.ViewModels;

namespace Test_Task_WPF.Services
{
    
    public class HttpRequestService
    {
        private HttpClient _httpClient => new HttpClient();

        public  void GetTopCoins()
        {
            if (StoreValueService.Coins != null)
                return;

            try
            {
                String request = "https://api.coingecko.com/api/v3/search/trending";
                HttpResponseMessage response = (_httpClient.GetAsync(request)).Result;
                string responseBody = response.Content.ReadAsStringAsync().Result;
                JObject jObject = JObject.Parse(responseBody);
                StoreValueService.Coins = jObject["coins"].ToObject<IEnumerable<Coin>>();
            }
            catch (Exception ex) 
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        public void GetFullInformationCoin(ItemViewModel item)
        {
            try
            {
                String request = $"https://api.coingecko.com/api/v3/coins/{item.Id}?localization=false&tickers=false&market_data=false&community_data=false&developer_data=false&sparkline=false";
                HttpResponseMessage response = (_httpClient.GetAsync(request)).Result;
                string responseBody = response.Content.ReadAsStringAsync().Result;
                var FullCoin = JObject.Parse(responseBody).ToObject<FullCoin>();
                StoreValueService.FullCoin = FullCoin;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        
        }
    }

}
