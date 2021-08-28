using System.ComponentModel;

namespace mvvm.Model
{
    public class SignUpInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string CheckPassword { get; set; }
    }
}