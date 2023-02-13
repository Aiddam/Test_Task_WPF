using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Test_Task_WPF.Enums;
using Test_Task_WPF.Models;
using Test_Task_WPF.Services;
using Test_Task_WPF.Stores;
using Test_Task_WPF.ViewModels;

namespace Test_Task_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private  IEnumerable<Coin> _coin;
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _coin = new List<Coin>();
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = CreateCoinListingViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

        private DetailViewModel CreateCurrenciesViewModel()
        {
            return new DetailViewModel(new NavigationService(_navigationStore, CreateCoinListingViewModel,
                CreateProfileViewModel, CreateExchangeRateViewModel));
        }
        private CoinListingViewModel CreateCoinListingViewModel()
        {
            return new CoinListingViewModel( _coin, new NavigationService(_navigationStore, CreateCurrenciesViewModel,
                CreateProfileViewModel, CreateExchangeRateViewModel));
        }
        private ProfileViewModel CreateProfileViewModel()
        {
            if(StoreValueService.User == null)
            {
                StoreValueService.User = new User("https://static.vecteezy.com/system/resources/thumbnails/009/665/304/small/cute-kitty-cat-head-cartoon-element-free-png.png",
                    "Anton", "Sharlai", "aiddamaddominator@gmail.com", Role.Administrator,
                    "Hard work is worthless for those that don't believe in themselves", "Pavlograd", "Ukraine",
                    "+(38) 0667046256", 500);
            }

            return new ProfileViewModel(StoreValueService.User, new NavigationService(_navigationStore,
                CreateCoinListingViewModel, CreateCurrenciesViewModel, CreateExchangeRateViewModel));
        }
        private ExchangeRateViewModel CreateExchangeRateViewModel()
        {
            return new ExchangeRateViewModel( new NavigationService(_navigationStore, CreateCoinListingViewModel,
                CreateProfileViewModel, CreateCurrenciesViewModel));
        }


    }

}
