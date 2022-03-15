using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using DataAccessLayer.Interface;
using DataAccessLayer;
using DataAccessLayer.Models;
using DataAccessLayer.Implementations;


namespace BusinessLayer.Implementations
{
    public class UserController : IUserController // för att nå unit of work så ska vi använda oss av interfacets IUNITOFWORk. genom att typ skriva = iunitofwork variabelnamn = iunitofwork ();
    {
        private readonly IUnitOfWork unitOfWork;
        

        public UserController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void AddUser(string email, string fullName, string password, string phoneNumber)
        {
            User user = new User()
            {
                Email = email,
                FullName = fullName,
                Password = password,
                PhoneNumber = phoneNumber
            };

            unitOfWork.Users.Add(user);

            unitOfWork.Complete();
        }

        public User GetByEmail(string email)
        {
            return unitOfWork.Users.GetByEmail(email);
        }

        // denna används just nu 

        public bool ExistByEmail(string email)
        {
            return unitOfWork.Users.ExistByEmail(email);
        }

        public IEnumerable<User> GetAll()
        {
            return unitOfWork.Users.GetAll();
        }

        

        User IUserController.ExistByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public bool SignIn(string email, string password)
        {
            
           return unitOfWork.Users.SignIn(email, password); 

        }



    }
} 
