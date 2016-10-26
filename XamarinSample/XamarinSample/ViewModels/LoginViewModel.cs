// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoginViewModel.cs" company="">
// </copyright>
// <summary>
//   The login view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XamarinSample.ViewModels
{
    using System;
    using System.ComponentModel;
    using System.Threading.Tasks;

    using Xamarin.Forms;

    using XamarinSample.Contract;
    using XamarinSample.Models;

    /// <summary>
    /// The login view model.
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        private string login;

        private string password;

        private Command loginCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Login
        {
            get { return this.login; }
            set
            {
                if (this.login != value)
                {
                    this.login = value;
                    this.OnPropertyChanged("Login");
                }
            }
        }

        public Command LoginCommand
        {
            get { return this.loginCommand ?? (this.loginCommand = new Command(async () => await this.ExecuteLoginCommand())); }

        }

        public string Password
        {
            get { return this.password; }
            set
            {
                if (this.password != value)
                {
                    this.password = value;
                    this.OnPropertyChanged("Password");
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            // if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private async Task ExecuteLoginCommand()
        {
            var error = false;
            try
            {
                Member memberLoginInfo = new Member { Login = this.Login, Password = this.Password };

                bool result =  DependencyService.Get<IAuthorizationService>().Login(memberLoginInfo);
                if (result)
                {
                    var page = new ContentPage();
                    await page.DisplayAlert("Success", "Success log in.", "OK");
                }
                else
                {
                    var page = new ContentPage();
                    await page.DisplayAlert("Login failed", "User cannot log in.", "OK");
                }
            }
            catch (Exception)
            {
                error = true;
            }

            if (error)
            {
                var page = new ContentPage();
                await page.DisplayAlert("Error", "User cannot log in.", "OK");
            }
        }
    }
}