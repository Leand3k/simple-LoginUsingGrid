using mvvm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //var ConnectionBinding = new DiscoveryPageViewModels();
            //this.BindingContext = ConnectionBinding;

            BindingContext = new DiscoveryPageViewModels();
        }
    }
}

//System.NullReferenceException
//  Message = Object reference not set to an instance of an object.
