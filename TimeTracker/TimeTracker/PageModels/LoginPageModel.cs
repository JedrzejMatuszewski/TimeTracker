using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TimeTracker.PageModels.Base;
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

        private INavigationService _navigationService;
        public LoginPageModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            SignInCommand = new Command(OnSignInAction);
        }

        private void OnSignInAction(object obj)
        {
            _navigationService.NavigateToAsync<DashboardPageModel>();
        }
    }
}
