using System.ComponentModel;

namespace mvvm.Model
{
    public class DiscoveryInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public string Title { get; set; }
        public string Image { get; set; }
        public string NumberOfPlaces { get; set; }
    }
}