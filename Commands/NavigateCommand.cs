using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Task_WPF.Models;
using Test_Task_WPF.Services;

namespace Test_Task_WPF.Commands
{
    class NavigateCommand :CommandBase
    {
        private readonly Item _item;
        private readonly NavigationService _navigationService;

        public NavigateCommand(Item item,NavigationService navigationService)
        {
            _item = item;
            _navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {

            _navigationService.Navigate();
        }
    }
}
