using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mvvm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeTabbedPage : TabbedPage
    {
        public HomeTabbedPage()
        {
            InitializeComponent();
        }
    }
}