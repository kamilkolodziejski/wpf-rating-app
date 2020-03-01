using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolodziejski.RatingApp.ViewModel
{
    public class BasePageViewModel : INotifyPropertyChanged, IViewModel
    {
        public void OnPropertyChanged(String propertyName)
        {
            if(propertyName != null)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if(handler != null)
                {
                    handler.Invoke(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
