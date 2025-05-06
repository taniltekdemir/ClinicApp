using Avalonia.Controls;

namespace ClinicApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new ClinicApp.ViewModels.LoginViewModel();
    }
}