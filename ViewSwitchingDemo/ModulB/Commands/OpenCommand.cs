using ModulB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModulB.Commands
{
    class OpenCommand : ICommand
    {
        ModulBViewModel viewModel;

        public event EventHandler CanExecuteChanged;

        public OpenCommand(ModulBViewModel vm)
        {
            viewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            viewModel.ShowModuleWindow();
        }
    }
}
