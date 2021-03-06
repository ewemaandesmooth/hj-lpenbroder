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


namespace DataAccessLayer.Implementations.Repository
{
    internal class PropertyRepository : GenericRepository<Property>, IPropertyRepository
    {
        public PropertyRepository(MyDbContext dbContext) : base(dbContext)
        {
        }
    }
}