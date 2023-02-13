using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Test_Task_WPF.Commands;
using Test_Task_WPF.Models;
using Test_Task_WPF.Services;

namespace Test_Task_WPF.ViewModels
{
    public class ExchangeRateViewModel:ViewModelBase
    {
        private decimal _value1;
        public decimal Value1
        {
            get { return _value1; }
            set { _value1 = value;
                _value2= value;
                OnPropertyChanged(nameof(Value1));
            }
        }
        private decimal _value2;
        public decimal Value2
        {
            get { return _value2; }
            set
            {
                if (Item1 != null && Item2 != null)
                    _value2 = (value * Item1.Price_Btc)/Item2.Price_Btc;
                OnPropertyChanged(nameof(Value2));
            }
        }

        private readonly ObservableCollection<ItemViewModel> _items;
        public IEnumerable<ItemViewModel> Items => _items;

        private ItemViewModel _item1;
        public ItemViewModel Item1
        {
            get { return _item1; }
            set
            {
                _item1 = value;
                Value2 = Value1;
            }
        }

        private ItemViewModel _item2;
        public ItemViewModel Item2
        {
            get { return _item2; }
            set
            {
                _item2 = value;
                Value2 = Value1;
            }
        }

        public ICommand NavigateToCoinListCommand { get; }

        public ExchangeRateViewModel(NavigationService navigationService)
        {
            NavigateToCoinListCommand = new NavigateToDetailCommand(navigationService);
            var coins = StoreValueService.Coins;
            _items = new ObservableCollection<ItemViewModel>();
            _items.Clear();
            foreach (var item in coins)
            {

                ItemViewModel itemViewModel = new ItemViewModel(item);
                _items.Add(itemViewModel);
            }
        }
    }
}
