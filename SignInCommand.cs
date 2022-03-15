using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.ViewModels;
using DataAccessLayer.Models;
using System.Windows.Input;
using MVVM.ViewModels.Command;
using MVVM.ViewModels.SignInViewModel;

namespace MVVM.ViewModels.Command
{


    public class SignInCommand : ICommand

    {
        private readonly SignIn signin;

        public SignInCommand(SignIn signin)
        {
            this.signin = signin;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        // EXECUTE() måste vara med och ska innehålla login funktionens kod. Inte knapp kod.
        //public void Execute(object parameter) // LOGINfunktion
        //{
        //    // Här utför vi inlogningen 
        //    //databasen = unitofworkeller db


        //   .Users.SignIn(email, password); <--- Exempel på syntax
        
        //}

    };

}
   


        
