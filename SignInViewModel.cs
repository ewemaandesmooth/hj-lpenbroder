using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataAccessLayer;
using System.Windows.Input;
using MVVM.ViewModels;
using MVVM.ViewModels.SignInViewModel;
using MVVM.ViewModels.Commands;
using DataAccessLayer.Models;
using DataAccessLayer.Implementations;
using MVVM.ViewModels.Command;

namespace MVVM.ViewModels.SignInViewModel
{
    public class SignIn : BaseViewModel
    {
        User model = new User();
        

        public string Email { get; set; }
        public string Password { get; set; }

        public ICommand SignInCommand { get; set; }


        public SignIn() // void är inte rätt här.
        {
            SignInCommand = new SignInCommand(this);
        }



        public bool VerifyPassword(string password)
        {
            
            return model.VerifyPassword(password);
            
        }
    }

}
