﻿using WPF_Project.Commands;
using WPF_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Project.ViewModels
{
    public class AddUserViewModel
    {

        public ICommand AddUserCommand { get; set; }

        public string? Name { get; set; }
        public string? Email { get; set; }

        public string? Sex { get; set; }

        public string? Age { get; set; }

        public AddUserViewModel()
        {
            AddUserCommand = new RelayCommand(AddUser, CanAddUser);

        }

        private bool CanAddUser(object obj)
        {
            return true;
        }

        private void AddUser(object obj)
        {

            UserManager.AddUser(new User() { Name = Name, Email = Email, Sex = Sex, Age = Age });

        }
    }
}