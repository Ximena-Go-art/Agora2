using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MovilApp.Views;
using MovilApp.Views.Login;

namespace MovilApp.ViewModels
{
    public partial class AgoraShellViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool userIsLogged = false;

        public IRelayCommand LogoutCommand { get; }
        public AgoraShellViewModel()//metodo que se llama igual que la clase (definir)
        {
                LogoutCommand = new RelayCommand(OnLogout);
            SetLoginState (false);//inicialmente no esta logeado
        }
        public void SetLoginState(bool isLoggedIn)
        {
            if (Application.Current?.MainPage is AgoraShell shell)
            {
                if (isLoggedIn)
                    shell.FlyoutBehavior = FlyoutBehavior.Flyout;
                else
                    shell.FlyoutBehavior = FlyoutBehavior.Disabled;

                userIsLogged = isLoggedIn;
                if (isLoggedIn)
                    shell.GoToAsync("//MainPage");  // Cambio a MainPage (pantalla de inicio)
                else
                    shell.GoToAsync("//Login");
            }

        }
        private void OnLogout()
            {
                SetLoginState(false);
        }
        
    }
}
