﻿using System;
using System.Windows.Input;

namespace TTLChanger
{
    class RelayCommand : ICommand
    {
        private Action _action;

        public RelayCommand(Action action)
        {
            _action = action;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action();
        }


    }
}
