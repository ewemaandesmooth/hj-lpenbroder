using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interface;
using DataAccessLayer.Models;
using DataAccessLayer.Interface.Repositories;
using DataAccessLayer.Implmentations;
using System.Data.Entity;
using System.Windows;

/*För UserRepository kommer signaturen bli följande då det har två metoderna är en utökning av de
metoder som finns i IGenericRepository och innehåller metoder för att söka efter och hämta
användare efter dess email.
Linq används vid filtreringen
 */

namespace DataAccessLayer.Implmentation.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {

        public UserRepository(MyDbContext dbContext) : base(dbContext)
        {
        }

        public bool ExistByEmail(string email)
        {
            return dbContext.Set<User>()
                .Where(user => user.Email == email)
                .Any();
        }

        public User GetByEmail(string email)
        {
            return dbContext.Set<User>()
                  .Where(user => user.Email == email)
                  .FirstOrDefault();

          
        }

        public bool SignIn(string email, string password)
            // Får inte ordning på detta! 
        {
            var user = GetByEmail(email);

            if (user != null && user.VerifyPassword(password))
            {
                return true;
            }

            else
            { return false; } // bör ligga i en kontroller inte i en repository
        }


    }

}
