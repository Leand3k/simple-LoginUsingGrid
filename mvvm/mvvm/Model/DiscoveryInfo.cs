using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace mvvm.Model
{
    public class DiscoveryInfo :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public string Title { get; set; }
        public string Image { get; set; }
        public string NumberOfPlaces { get; set; }

    }
}
