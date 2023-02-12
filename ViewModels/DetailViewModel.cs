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

namespace Test_Task_WPF.ViewModels
{
   public class DetailViewModel:ViewModelBase
    {
        private ItemViewModel _item;
        public  ItemViewModel Item
        {
            get {  return _item;  }
            set { _item = value; OnPropertyChanged("Item"); }
        }
        public ICommand CoinListCommand { get; }
        public DetailViewModel(NavigationService navigationService)
        {
            Item = StoreValueService.Item;
            CoinListCommand = new NavigateToDetailCommand(navigationService);
        }
    }
}
