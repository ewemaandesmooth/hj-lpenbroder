using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using BusinessLayer.Implementations;

namespace BusinessLayer.Interfaces
{
    public interface IUserController
    {
        void AddUser(string email, string fullName, string password, string phonenumber);

        IEnumerable<User> GetAll();

        User GetByEmail(string email);
        User ExistByEmail(string email);

        bool SignIn(string email, string password);
        
    }
}
