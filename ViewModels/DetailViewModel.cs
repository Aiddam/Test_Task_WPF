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
        private FullCoin _fullCoin;
        public  FullCoin FullCoin
        {
            get {  return _fullCoin;  }
            set { _fullCoin = value; OnPropertyChanged("FullCoin"); }
        }

        public ICommand NavigateToCoinListCommand { get; }
        public DetailViewModel(NavigationService navigationService)
        {
            _fullCoin = StoreValueService.FullCoin;
            NavigateToCoinListCommand = new NavigateToDetailCommand(navigationService);
        }
    }
}
