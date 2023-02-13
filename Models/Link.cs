using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Task_WPF.Models
{
    public class Link
    {
        [JsonProperty("homepage")]
        public List<string> HomePage { get; set; }
        [JsonProperty("blockchain_site")]
        public List<string> Blockchain_Site { get; set; }
        [JsonProperty("official_forum_url")]
        public List<string> Official_Forum_Url { get; set; }


    }
}
