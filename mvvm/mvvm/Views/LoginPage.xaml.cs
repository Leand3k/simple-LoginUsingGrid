using mvvm.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mvvm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            var ConnectionBinding = new LoginPageViewModel();
            this.BindingContext = ConnectionBinding;
            ConnectionBinding.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");
            InitializeComponent();
        }
    }
}