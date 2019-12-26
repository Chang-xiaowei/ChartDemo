using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Utility.WpfGUI
{
    public sealed class RelayCommand : ICommand
    {
        public Action<object> ExecuteCommand = null;
        public Func<object, bool> CanExecuteCommand = null;

        public event EventHandler CanExecuteChanged;
        public RelayCommand(Action<object> execute, Func<object, bool> canExecuteCommand = null)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }
            ExecuteCommand = execute;
            CanExecuteCommand = canExecuteCommand;
        }
        public bool CanExecute(object parameter)
        {
            if (CanExecuteCommand != null)
            {
                return CanExecuteCommand(parameter);
            }
            return true;
        }
        public void Execute(object parameter)
        {
            if (ExecuteCommand != null)
            {
                ExecuteCommand.DynamicInvoke(parameter);
            }
        }
        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}
