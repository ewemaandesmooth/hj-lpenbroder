using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.ViewModels;
using DataAccessLayer.Models;
using System.Windows.Input;
using MVVM.ViewModels.Registerview; // uppdatera till rätt mappnamn
namespace MVVM.ViewModels.Commands
{
    public class RegisterCommand : ICommand
         
    {
        private readonly RegisterViewModel registerViewModel;

        public RegisterCommand(RegisterViewModel registerViewModel)
        {
            this.registerViewModel = registerViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            User newUser = new User()
            {
                Email = registerViewModel.Email,
                FullName = registerViewModel.FullName,
                Password = registerViewModel.Password
            };


            App.Datamanager.Add(newUser);
        }
    }
}
