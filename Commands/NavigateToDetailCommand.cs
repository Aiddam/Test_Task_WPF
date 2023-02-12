using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Task_WPF.Models;
using Test_Task_WPF.Services;
using Test_Task_WPF.ViewModels;

namespace Test_Task_WPF.Commands
{
    public class NavigateToDetailCommand : CommandBase
    {
        private readonly NavigationService _navigationService;

        public NavigateToDetailCommand(NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.Navigate();
        }


    }
}
