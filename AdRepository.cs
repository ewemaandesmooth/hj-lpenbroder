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


/*Detta repository syftar till att lagra och
behandla “ads”-klasser. Eftersom den ärver av IGenericRepository (som vi precis har skapat)
kommer klasser som implementerar IadsRepository “automatiskt” även få de metoder som finns i
IGenericRepository. Eftersom detta interface inte behöver ytterligare funktionalitet räcker det att dess
kropp lämnas tom*/

//detta gäller samtliga ad, property osvosv Repositories classer förutom user


namespace DataAccessLayer.Implementations.Repository
{
    internal class AdRepository : GenericRepository<Ad>, IAdRepository
    {
        public AdRepository(MyDbContext dbContext) :base (dbContext)
        {


        }
    }
}

