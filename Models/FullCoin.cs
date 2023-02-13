using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Task_WPF.Services;

namespace Test_Task_WPF.Models
{
    public class FullCoin
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        [JsonProperty("NAME")]
        public string Name { get; set; }
        public string Image_Small
        {
            get { return ImageData.Large; }
        }
        [JsonProperty("IMAGE")]
        public Image ImageData { get; set; }
        [JsonProperty("LINKS")]
        public Link Link { get; set; }
        [JsonProperty("Market_Cap_Rank")]
        public int Market_Cap_Rank { get; set; }
        [JsonProperty("Coingecko_Rank")]
        public double? CoingeckoRank { get;set; }
        [JsonProperty("Coingecko_Score")]
        public string CoingeckoScore { get; set; }
        [JsonProperty("description")]
        public Description Description { get; set; }
    }
}
