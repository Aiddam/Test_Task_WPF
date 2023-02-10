using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Test_Task_WPF.Commands;
using Test_Task_WPF.Models;
using Test_Task_WPF.Services;
using Test_Task_WPF.Views;

namespace Test_Task_WPF.ViewModels
{
    class CoinListingViewModel :ViewModelBase
    {
        private readonly IEnumerable<Coin> _coin;
        private Item _item;
        public Item Item
        {
            get { return _item; }
            set { _item = value; OnPropertyChanged(nameof(Item));}
        }
        private readonly ObservableCollection<ItemViewModel> _items;
        public ICommand DetailedViewCommand { get; }
        public IEnumerable<ItemViewModel> Items => _items;

        public CoinListingViewModel(IEnumerable<Coin> coin, NavigationService navigationService)
        {
            HttpRequestService httpRequestService = new HttpRequestService();
            coin = httpRequestService.GetTopCoins();
            _coin = coin;
            _items = new ObservableCollection<ItemViewModel>();
            DetailedViewCommand = new NavigateCommand(_item,navigationService);
            UpdateCoins();
        }

        private void UpdateCoins()
        {
           
            _items.Clear();
            if (_coin == null)
                return;
            foreach (var item in _coin)
            {

                ItemViewModel itemViewModel = new ItemViewModel(item);
                _items.Add(itemViewModel);
            }

        }
    }
}
