using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Task_WPF.Services;

namespace Test_Task_WPF.Commands
{
    public class NavigateToExchangeRateCommand:CommandBase
    {
        private readonly NavigationService _navigationService;

        public NavigateToExchangeRateCommand(NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.NavigateToAnotherOne();
        }

    }
}
