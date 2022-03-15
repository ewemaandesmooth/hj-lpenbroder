using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interface.Repositories;
using DataAccessLayer.Models;


namespace DataAccessLayer.Interface.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByEmail(string email);
        bool ExistByEmail(string email); // vad ska den retunera?

        bool SignIn(string email, string password);
    }
}
