using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM.ViewModels.Commands;

namespace MVVM.ViewModels.Registerview
{
    public abstract class RegisterViewModel : BaseViewModel
    {
        
        public string Email { get; set; }

        public string FullName { get; set; }
        public string Password { get; set; }

        public ICommand RegisterUserCommand { get; set; }

        public RegisterViewModel()
        {
            RegisterUserCommand = new RegisterCommand(this);
        }

    }
}
