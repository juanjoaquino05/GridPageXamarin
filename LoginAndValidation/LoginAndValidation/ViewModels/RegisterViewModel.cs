using LoginAndValidation.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LoginAndValidation.ViewModels
{
    class RegisterViewModel : BaseViewModel
    {
        private static Page page;
        public Command RegisterCommand { get; }

        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); }
        }

        private String email;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        private String name;
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }

        private String password;
        public string PasswordConfirm
        {
            get { return passwordConfirm; }
            set { SetProperty(ref passwordConfirm, value); }
        }

        private String passwordConfirm;


        public RegisterViewModel()
        {
            RegisterCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            String message = "";
            String title = "Error";

            var nameIsEmpty = String.IsNullOrEmpty(Name);
            var emailIsEmpty = String.IsNullOrEmpty(Email);
            var passwordIsEmpty = String.IsNullOrEmpty(Password);
            var confirmPasswordIsEmpty = String.IsNullOrEmpty(PasswordConfirm);

            Boolean error;

            var passwordAndConfirmMatch = Password.Equals(Password);

            if (nameIsEmpty)
            {
                message = "Campo Name no puede estar vacío";
            }
            else if (emailIsEmpty)
            {
                message = "Campo Email no puede estar vacío";
            }
            else if (passwordIsEmpty)
            {
                message = "Campo Password no puede estar vacío";
            }
            else if (confirmPasswordIsEmpty)
            {
                message = "Campo Password Confirm no puede estar vacío";
            }
            else if (passwordAndConfirmMatch)
            {
                message = "Las Claves no concuerdan";
            }
            
            error = nameIsEmpty || emailIsEmpty || passwordIsEmpty || confirmPasswordIsEmpty || passwordAndConfirmMatch;
            if (error)
            {
                await App.Current.MainPage.DisplayAlert(title, message, "OK");
            }
            else
            {
                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
        }
    }
}
