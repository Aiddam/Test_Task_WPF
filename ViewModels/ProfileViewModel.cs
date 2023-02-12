﻿using System;
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
        public ICommand NavigateToCoinListCommand { get; }
        private  User _user;
        public User User
        {
            get { return _user; }
            set { _user = value;}
        }
        public ProfileViewModel(NavigationService navigationService,User user)
        {
            User = user;
            NavigateToCoinListCommand = new NavigateToDetailCommand(navigationService);
        }
    }
}