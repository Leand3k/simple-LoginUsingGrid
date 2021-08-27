using Acr.UserDialogs;
using mvvm.Views;
using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace mvvm.ViewModels
{
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        private string email;
        public Action DisplayInvalidLoginPrompt;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public string InputEmail
        {
            get { return email; }
            set
            {
                email = value;
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

            NavigateCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());


            });
        }

        public async void Check()
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                await App.Current.MainPage.DisplayAlert("Wait!", "Fields can't be empty", "OK");
            }
            else
            {
                UserDialogs.Instance.Toast($"Welcome {InputEmail}", TimeSpan.FromSeconds(5));
            }
        }




        public ICommand NavigateCommand { get; }

        

        
        
    }
}