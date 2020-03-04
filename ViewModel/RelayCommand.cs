using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kolodziejski.RatingApp.ViewModel
{
    public class RelayCommand : ICommand
    {
        Action<Object> _executeMethod;
        Predicate<object> _canExecuteMethod;

        public RelayCommand(Action<object> executeMethod)
        {
            _executeMethod = executeMethod;
        }
        public RelayCommand(Action<object> executeMethod, Predicate<object> canExecuteMethod)
        {
            _executeMethod = executeMethod;
            _canExecuteMethod = canExecuteMethod;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameters)
        {
            if(_canExecuteMethod != null)
            {
                return _canExecuteMethod(parameters);
            }
            return true;
        }

        public void Execute(object parameters)
        {
            if(_executeMethod != null)
            {
                _executeMethod(parameters);
            }
        }
    }
}
