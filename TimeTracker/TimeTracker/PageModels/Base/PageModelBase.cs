using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TimeTracker.PageModels.Base
{
    public class PageModelBase : BindableObject
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

        public virtual Task InitializeAsync(object navigationDate = null)
        {
            return Task.CompletedTask;
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if(EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

    }
}
