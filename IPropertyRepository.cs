using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DataAccessLayer.Interface.Repositories;

namespace DataAccessLayer.Interface
{
    public interface IPropertyRepository : IRepository<Property>
    {
    }
}
