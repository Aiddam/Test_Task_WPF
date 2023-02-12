using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
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
            return new DetailViewModel(new NavigationService(_navigationStore, CreateCoinListingViewModel, CreateProfileViewModel));
        }
        private CoinListingViewModel CreateCoinListingViewModel()
        {
            return new CoinListingViewModel( _coin, new NavigationService(_navigationStore, CreateCurrenciesViewModel, CreateProfileViewModel));
        }
        private ProfileViewModel CreateProfileViewModel()
        {
            return new ProfileViewModel(new NavigationService(_navigationStore, CreateCoinListingViewModel, CreateCurrenciesViewModel));
        }


    }

}
