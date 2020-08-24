using System;
using System.Windows.Input;

namespace Radio
{
    public class Command<T> : ICommand
    {
        private Action<T> ExecuteDelegate;

        private Predicate<T> CanExecuteDelegate;

        public event EventHandler CanExecuteChanged;

        public Command(Action<T> executeDelegate, Predicate<T> canExecuteDelegate)
        {
            if (executeDelegate == null || canExecuteDelegate == null)
                throw new ArgumentNullException();
            
            ExecuteDelegate = executeDelegate;
            CanExecuteDelegate = canExecuteDelegate;
        }

        public Command(Action<T> executeDelegate) : this(executeDelegate, x => true) { }

        public bool CanExecute(object parameter)
        {
            return CanExecuteDelegate((T)parameter);
        }

        public void Execute(object parameter)
        {
            ExecuteDelegate((T)parameter);
        }
    }
}
