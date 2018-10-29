using System;
using System.Windows.Input;

namespace CommandExam
{
    class RelayCommand :ICommand
    {
        Func<object, bool> canExecute;
        Action<object> executeAction;

        public RelayCommand(Action<object> executeAction) : this(executeAction, null) {}

        public RelayCommand(Action<object> executeAction, Func<object, bool> canExecute) {
            this.executeAction = executeAction ?? //if (executeAction == null) 
                throw new ArgumentNullException("Execute Action was null for ICommanding Operation.");
            this.canExecute = canExecute;
        }

        public bool CanExecute(object param) {
            if (param?.ToString().Length == 0) return false;
            bool result = this.canExecute == null ? true : this.canExecute.Invoke(param);
            return result;
        }

        public void Execute(object param) {
            this.executeAction.Invoke(param);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
