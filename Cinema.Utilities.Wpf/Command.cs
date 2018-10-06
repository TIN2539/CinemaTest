using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cinema.Utilities.Wpf
{
    public abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute() => true;

        public abstract void Execute();

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        bool ICommand.CanExecute(object parameter)
        {
            return CanExecute();
        }

        void ICommand.Execute(object parameter)
        {
            Execute();
        }
    }
}
