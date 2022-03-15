using BusinessLayer.Implementations;
using BusinessLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Implementations;
using DataAccessLayer.Interface;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*För att kunna exekvera koden vill vi skapa ett Konsol-projekt (Console Application). Lägg märke att
vi här instansierar de konkreta klasser vi tidigare skapat i Business Layer och i Data Access Layer och
“gömmer” dessa bakom dess tillhörande interfaces. Följande exempel (nästa sida) innehåller två
metoder för att lägga in nya användare och en metod för att hämta och skriva ut alla användare.
Observera att ni även behöver installera Entity Framework 6 i presentationslagret för att kunna
instansiera er DbContext.*/

namespace PresentationLayerConsole 
{
    public class AirBnbConsole
    {
        MyDbContext dbContext;
        UnitOfWork unitOfWork;

        IUserController userController;
        IAdController adController;
        IPropertyController propertyController;
        IReservationController reservationController;
        IFacilityController facilityController;

        public AirBnbConsole()
        {
            dbContext = new MyDbContext();
            unitOfWork = new UnitOfWork(dbContext);
            userController = new UserController(unitOfWork);

            adController = new AdController(unitOfWork);
            propertyController = new PropertyController(unitOfWork);
            reservationController = new ReservationController(unitOfWork);
            facilityController = new FacilityController(unitOfWork);
        }



        public void AddData ()
        {
            //dbContext.Reset();
             userController.AddUser("Anna@email.com", "Anna andersson", "anna123", "070-00000"); // Blir det inte att vi lägger in denna varje gång nu?Databasen registrerar inte nya utan bara denna varje gång.
        } 
        

        public bool SignIn(string email, string password)
        {
            return userController.SignIn(email, password);
        }



        public void Run()
        {

            PrintAllUsers();

        }


        private void PrintAllUsers()
        {
            IEnumerable<User> users = userController.GetAll();

            Console.WriteLine("All users: ");
            foreach (User user in users)
            {
                Console.WriteLine($"{user.FullName} - {user.Email}");
            }
        }
        
    }
}
        

