using MovilApp.ViewModels;
using MovilApp.Views.Login;
using Microsoft.Maui.Controls;


namespace MovilApp.Views;

public partial class AgoraShell : Shell
{
    public AgoraShellViewModel ViewModel => (AgoraShellViewModel)BindingContext;
    public AgoraShell()
    {
        InitializeComponent();
    }
    public void SetLoginState(bool isLoggedIn)
    {
        ViewModel.SetLoginState(isLoggedIn);
        //hace referencia al shellviewmodel para cambiar el estado de login cuando nos acabamos de logear.

    }
}