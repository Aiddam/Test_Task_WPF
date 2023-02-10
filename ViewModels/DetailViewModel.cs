using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Task_WPF.Models;
using Test_Task_WPF.Services;

namespace Test_Task_WPF.ViewModels
{
    class DetailViewModel:ViewModelBase
    {
        private readonly Item _item;
        public DetailViewModel(Item item,NavigationService navigationService)
        {
            _item = item;
        }
    }
}
