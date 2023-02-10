using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Test_Task_WPF.Models;
using Test_Task_WPF.Views;

namespace Test_Task_WPF.ViewModels
{
    class CoinListingViewModel :ViewModelBase
    {
        private readonly Coin _coin;
        private readonly ObservableCollection<ItemViewModel> _items;
        public IEnumerable<ItemViewModel> Items => _items;

        public CoinListingViewModel()
        {
            _items = new ObservableCollection<ItemViewModel>();
            _items.Clear();
            _items.Add(new ItemViewModel(new Coin(new Item(){ Id = "s" })));
            _items.Add(new ItemViewModel(new Coin(new Item() { Id = "ssss" })));
        }
    }
}
