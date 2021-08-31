using mvvm.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mvvm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoveryPage : ContentPage
    {
        public DiscoveryPage()
        {
            InitializeComponent();

            BindingContext = new DiscoveryPageViewModels();
        }
    }
}