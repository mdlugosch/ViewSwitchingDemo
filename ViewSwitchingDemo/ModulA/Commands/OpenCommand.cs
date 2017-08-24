using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using ModulA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModulA.Commands
{
    class OpenCommand : ICommand
    {
        ModulAViewModel viewModel;

        public event EventHandler CanExecuteChanged;

        public OpenCommand(ModulAViewModel vm)
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
