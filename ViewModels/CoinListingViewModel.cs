using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Test_Task_WPF.Models;
using Test_Task_WPF.Services;
using Test_Task_WPF.Views;

namespace Test_Task_WPF.ViewModels
{
    class CoinListingViewModel :ViewModelBase
    {
        private readonly Coin _coin;
        private readonly ObservableCollection<ItemViewModel> _items;
        public ICommand DetailedViewCommand { get; }
        public IEnumerable<ItemViewModel> Items => _items;

        public CoinListingViewModel(Coin coin, NavigationService navigationService)
        {
            _coin = coin;
            _items = new ObservableCollection<ItemViewModel>();

            UpdateCoins();
        }

        private void UpdateCoins()
        {
            _items.Clear();
            ItemViewModel itemViewModel = new ItemViewModel(_coin);
            _items.Add(itemViewModel);
        }
    }
}
