using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test_Task_WPF.Models
{
    public class Item:INotifyPropertyChanged
    {
        private string? _id;
        public string Id
        {
            get { return _id ?? "Unknown"; }
            set { _id = value; OnPropertyChanged(); }
        }
        private int _coin_Id;
        public int Coin_Id
        {
            get { return _coin_Id; }
            set { _coin_Id = value; OnPropertyChanged(); }
        }
        private string? _name;
        public string Name
        {
            get { return _name ?? "Unknown"; }
            set { _name = value; OnPropertyChanged(); }
        }
        private string? _symbol { get; set; }
        public string Symbol
        {
            get { return _symbol ?? "Unknown"; }
            set { _symbol = value; OnPropertyChanged(); }
        }
        private int _market_Cap_Rank { get; set; }
        public int Market_Cap_Rank
        {
            get { return _market_Cap_Rank; }
            set { _market_Cap_Rank = value; OnPropertyChanged(); }
        }
        private string? _thumb { get; set; }
        public string Thumb
        {
            get { return _thumb ?? "Unknown"; }
            set { _thumb = value; OnPropertyChanged(); }
        }
        private string? _small { get; set; }
        public string Small
        {
            get { return _small ?? "Unknown"; }
            set { _small = value; OnPropertyChanged(); }
        }
        private string? _large { get; set; }
        public string Large
        {
            get { return _large ?? "Unknown"; }
            set { _large = value; OnPropertyChanged(); }
        }
        private string? _slug { get; set; }


        public string Slug
        {
            get { return _slug ?? "Unknown"; }
            set { _slug = value; OnPropertyChanged(); }
        }
        private double _price_Btc { get; set; }
        public double Price_Btc
        {
            get { return _price_Btc; }
            set { _price_Btc = value; OnPropertyChanged(); }
        }
        private int _score { get; set; }
        public int Score
        {
            get { return _score; }
            set { _score = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
}
