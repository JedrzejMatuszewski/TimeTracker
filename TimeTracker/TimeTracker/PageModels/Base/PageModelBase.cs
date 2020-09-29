using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TimeTracker.PageModels.Base
{
    public class PageModelBase : ExtendedBindableObject
    {
        string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        bool _isloading;
        public bool Isloding
        {
            get => _isloading;
            set => SetProperty(ref _isloading, value);
        }

        public virtual Task InitializeAsync(object navigationData = null)
        {
            return Task.CompletedTask;
        }

    }
}
