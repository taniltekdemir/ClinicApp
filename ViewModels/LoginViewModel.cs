using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ReactiveUI;

namespace ClinicApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _username;
        public string Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(); }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }

        private string _message;
        public string Message
        {
            get => _message;
            set { _message = value; OnPropertyChanged(); }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = ReactiveCommand.Create(Login);
        }

        private void Login()
        {
            if (Username == "admin" && Password == "1234")
            {
                Message = "Giriş başarılı!";
            }
            else
            {
                Message = "Hatalı kullanıcı adı veya şifre.";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
