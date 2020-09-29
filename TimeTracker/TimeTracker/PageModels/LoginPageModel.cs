using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TimeTracker.PageModels.Base;
using TimeTracker.Services.Account;
using TimeTracker.Services.Navigation;
using Xamarin.Forms;

namespace TimeTracker.PageModels
{
    class LoginPageModel : PageModelBase
    {
        private ICommand _signInCommand;

        public ICommand SignInCommand
        {
            get => _signInCommand;
            set => SetProperty(ref _signInCommand, value);
        }

        private string _username;
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private INavigationService _navigationService;
        private IAccountService _accountService;

        public LoginPageModel(INavigationService navigationService, IAccountService accountService)
        {
            _navigationService = navigationService;
            _accountService = accountService;

            SignInCommand = new Command(DoLogInActionAsync);
        }

        private async void DoLogInActionAsync(object obj)
        {
            var loginAttempt = await _accountService.LoginAsync(Username, Password);
            if(loginAttempt)
            {
                await _navigationService.NavigateToAsync<DashboardPageModel>();
            }
            else
            {
                //TODO: Display an alert for Failure
            }


            
        }
    }
}
