using System.ComponentModel;

namespace ClinicApp.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _greeting = "Merhaba ClinicApp!";
        public string Greeting
        {
            get => _greeting;
            set
            {
                _greeting = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Greeting)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
