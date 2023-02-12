using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public DetailViewModel(NavigationService navigationService)
        {
            Item = StoreValueService.Item;
        }
    }
}
