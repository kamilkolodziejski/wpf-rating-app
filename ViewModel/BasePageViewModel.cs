using Kolodziejski.RatingApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kolodziejski.RatingApp.ViewModel
{
    public class BasePageViewModel : INotifyPropertyChanged, IViewModel
    {
        //protected virtual void OnPropertyChanged(String propertyName)
        //{
        //    if (propertyName != null)
        //    {
        //        PropertyChangedEventHandler handler = PropertyChanged;
        //        if (handler != null)
        //        {
        //            handler.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //        }
        //    }
        //}        
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected bool SetValue<T>(ref T field, T value)
        {
            if(EqualityComparer<T>.Default.Equals(field,value))
            {
                return false;
            }
            field = value;
            OnPropertyChanged();
            return true;
        }

        //protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        //{
        //    if(Equals(field, value))
        //    {
        //        return false;
        //    }

        //    field = value;
        //    this.OnPropertyChanged(propertyName);
        //    return true;
        //}
    }
}
