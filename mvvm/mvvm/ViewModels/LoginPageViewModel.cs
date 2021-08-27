﻿using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace mvvm.ViewModels
{
    

    public class LoginPageViewModel : INotifyPropertyChanged
    {
        private string username;
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };



        public string InputUsername
        {
            get { return username; }
            set
            {
                username = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Username"));
            }
        }

        private string password;
        public string InputPassword
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        public ICommand CheckInput { set; get; }
        public LoginPageViewModel()
        {
            CheckInput = new Command(Check);
        }

        public void Check()
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                UserDialogs.Instance.Toast("Empty fields. Fill it up.", TimeSpan.FromSeconds(3));
            }
            else
            {
                UserDialogs.Instance.Toast($"Welcome {InputUsername}", TimeSpan.FromSeconds(5));
            }
        }





    }
}