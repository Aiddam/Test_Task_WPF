using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Task_WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        
        public ViewModelBase CurrentViewModel { get; }
        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        public MainViewModel()
        {
            CurrentViewModel = new CoinListingViewModel();
        }
    }
}
