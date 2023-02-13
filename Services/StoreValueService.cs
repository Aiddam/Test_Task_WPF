using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Task_WPF.Models;
using Test_Task_WPF.ViewModels;

namespace Test_Task_WPF.Services
{
    public static class StoreValueService
    {
        public static ItemViewModel? Item;
        public static IEnumerable<Coin>? Coins;
        public static User? User;
        public static FullCoin? FullCoin;
    }
}
