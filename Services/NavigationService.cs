using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Task_WPF.Models;
using Test_Task_WPF.Stores;
using Test_Task_WPF.ViewModels;

namespace Test_Task_WPF.Services
{
    public class NavigationService
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<ViewModelBase> _createViewModel;
        private readonly Func<ViewModelBase> _createAnotherViewModel;
        private readonly Func<ViewModelBase> _createAnotherOneViewModel;

        public NavigationService(NavigationStore navigationStore,
                                 Func<ViewModelBase> createViewModel,
                                 Func<ViewModelBase> createAnotherViewModel,
                                 Func<ViewModelBase> createAnotherOneViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
            _createAnotherViewModel = createAnotherViewModel;
            _createAnotherOneViewModel = createAnotherOneViewModel;
        }
        public void Navigate()
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
        public void NavigateToAnother()
        {
            _navigationStore.CurrentViewModel = _createAnotherViewModel();
        }
        public void NavigateToAnotherOne()
        {
            _navigationStore.CurrentViewModel = _createAnotherOneViewModel();
        }
    }
}
