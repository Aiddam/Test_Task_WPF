using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Test_Task_WPF.Commands;
using Test_Task_WPF.Models;
using Test_Task_WPF.Services;

namespace Test_Task_WPF.ViewModels
{
    public class ProfileViewModel:ViewModelBase
    {
        private  User _user;
        public User User
        {
            get { return _user; }
            set { _user = value;}
        }

        public ICommand NavigateToCoinListCommand { get; }

        public ProfileViewModel(User user, NavigationService navigationService)
        {
            User = user;
            NavigateToCoinListCommand = new NavigateToDetailCommand(navigationService);
        }
    }
}
