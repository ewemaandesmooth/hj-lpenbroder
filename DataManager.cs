using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Models;
using DataAccessLayer.Implementations;

namespace DataAccessLayer
{
    // Denna klassen finns för att man ska kunna registrera en användare
    public class DataManager

    {
        UnitOfWork unitOfWork = new UnitOfWork(new MyDbContext());
        
        private readonly List<User> users = new List<User>();

        public IEnumerable<User> GetAll()
        {
            return users;
        }

        public void Add(User user)
        {
            users.Add(user);
        }
        
        public void Remove (User user)
        {
            users.Remove(user);
        }

        // LOGIN funktion SKA FINNAS HÄR, HJÄLP?!
        
        public void RegisterUser (User user)

        {

            using (var db = new MyDbContext())
            {
                User newUser = new User()
                {
                    Email = user.Email,
                    FullName = user.FullName,
                    Password = user.Password,
                    PhoneNumber = user.PhoneNumber

                };
                db.Users.Add(newUser);
                



            }

        }



    }
}
