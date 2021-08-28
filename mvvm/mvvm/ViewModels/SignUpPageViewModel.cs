using mvvm.Model;
using mvvm.Views;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace mvvm.ViewModels
{
    public class SignUpPageViewModel : INotifyPropertyChanged
    {
        public ICommand CheckSignUpCommand { set; get; }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public SignUpInfo SignUp { get; set; } = new SignUpInfo();

        public SignUpPageViewModel()
        {
            CheckSignUpCommand = new Command(CheckSignUp);
        }

        public async void CheckSignUp()
        {
            if (string.IsNullOrEmpty(SignUp.Email) || string.IsNullOrEmpty(SignUp.Password) || string.IsNullOrEmpty(SignUp.Name) || string.IsNullOrEmpty(SignUp.CheckPassword))
            {
               

                await App.Current.MainPage.DisplayAlert("Wait!", "Fields can't be empty", "OK");
            }
            else if (SignUp.Password != SignUp.CheckPassword)
            {
                await App.Current.MainPage.DisplayAlert("Hold on!", "These passwords don't match", "Try Again");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Welcome", $"Hi {SignUp.Name}", "Done");
                await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
            }
        }
    }
}