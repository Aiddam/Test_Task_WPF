using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace Test_Task_WPF.Models
{
    public class Image
    {
        private string _thumb;
        [JsonPropertyName("thumb")]
        public string Thumb
        {
            get { return _thumb ?? "Unknown"; }
            set { _thumb = value; }
        }
        private string? _small { get; set; }
        [JsonPropertyName("small")]
        public string Small
        {
            get { return _small ?? "Unknown"; }
            set { _small = value; }
        }
        private string? _large { get; set; }
        [JsonPropertyName("large")]
        public string Large
        {
            get { return _large ?? "Unknown"; }
            set { _large = value; }
        }
    }
}
