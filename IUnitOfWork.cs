using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DataAccessLayer.Implementations.Repository;
using DataAccessLayer.Interface;
using DataAccessLayer.Implementations;
using DataAccessLayer.Interface.Repositories;

namespace DataAccessLayer.Interface

/*UnitOfWork innehåller i sin tur dessa våra repository interfaces vi skapat. Den har även två metodsignaturer,
Seed och Complete. Avsikten med Seed-metoden är att skapa “fakedata” i databasen så att man
slipper skapa alla rader genom att köra slutprogrammet. Avsikten med Complete-metoden är att spara
ner allt som finns i de olika repositoryna, eftersom vi kommer använda oss av Entity Framework och
SQL-server kommer Complete att spara informationen till en relationsdatabas*/
{
    public interface IUnitOfWork
    {

        IUserRepository Users { get; set; }

        IAdRepository Ads { get; set; }
        IReservationRepository Reservations { get; set; }
        IPropertyRepository Properties { get; set; }
        IFacilityRepository Facilities { get; set; }

       
        void Complete();
    }
}

