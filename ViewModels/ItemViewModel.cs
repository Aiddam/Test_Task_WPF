using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Test_Task_WPF.Models;

namespace Test_Task_WPF.ViewModels
{
    class ItemViewModel:ViewModelBase
    {
        private readonly Coin _coin;

        public string Id => _coin.Item.Id;
        public int Coin_Id => _coin.Item.Coin_Id;
        public string Name => _coin.Item.Name;
        public string Symbol=> _coin.Item.Symbol;
   
        public int Market_Cap_Rank => _coin.Item.Market_Cap_Rank;
        public string Thumb => _coin.Item.Thumb;
        public string Small=> _coin.Item.Small;
        public string Large=> _coin.Item.Large;


        public string Slug=> _coin.Item.Slug;
        public double Price_Btc => _coin.Item.Price_Btc;
        public int Score => _coin.Item.Score;


        public ItemViewModel(Coin coin)
        {
            _coin = coin;
        }
    }
}
