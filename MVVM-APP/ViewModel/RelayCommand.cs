using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_APP.ViewModel
{
    class RelayCommand : ICommand
    {
        #region Members
        readonly Func<bool> _canExecuteInventory;
        readonly Action _executeInventory;
        #endregion

        #region Constructor
        public RelayCommand(Func<bool> CanExecuteInventory,Action ExecuteInventory)
        {
            _canExecuteInventory = CanExecuteInventory;
            _executeInventory = ExecuteInventory;
        }
        #endregion

        #region Icommand Methods

        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExecuteInventory != null)
                    CommandManager.RequerySuggested += value;
            }                                                     
            remove
            {
                if (_canExecuteInventory != null)
                    CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecuteInventory == null ? true : _canExecuteInventory();
        }

        public void Execute(object parameter)
        {
            _executeInventory();
        }

        #endregion
    }
}
