using LoginAndValidation.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginAndValidation.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private static Page page;
        public Command LoginCommand { get; }
        public Command RegisterCommand { get; }

        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); }
        }

        private String email;
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }

        private String password;

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            RegisterCommand = new Command(OnRegisterClicked);

            Email = "JJ";
            Password = "somepass";
        }

        private async void OnLoginClicked(object obj)
        {
            String message, title;
            var passwordIsEmpty = String.IsNullOrEmpty(Password);
            var emailIsEmpty = String.IsNullOrEmpty(Email);

            if (emailIsEmpty || passwordIsEmpty)
            {
                title = "Error";
                message = "Campo Email y/o contraseña no puede estar vacío";
                await App.Current.MainPage.DisplayAlert("Alert", message, "OK");
            }
            else
            {
                title = "Bienvenido";
                message = "Hola " + Email; 
                await App.Current.MainPage.DisplayAlert("Alert", message, "OK");
                await App.Current.MainPage.Navigation.PushAsync(new HomePage());
                    //Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
        }

        private async void OnRegisterClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(RegisterPage)}");
        }
    }
}
