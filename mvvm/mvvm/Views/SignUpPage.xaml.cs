using mvvm.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mvvm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            var vm = new SignUpPageViewModel();
            this.BindingContext = vm;

            InitializeComponent();
        }
    }
}