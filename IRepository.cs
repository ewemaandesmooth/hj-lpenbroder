using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using System.Data.Entity;
using System.Linq.Expressions;

/*Följande är implementeringen av IGenericRepository. Lägg märke till att den lagrar ett
DbContext-objekt i en variabel som har publiciteten protected. Att den är protected (till skillnad från
private) innebär att klasser som ärver från GenericRepository (exempelvis UserRepository) kan
accessa den.*/
namespace DataAccessLayer.Interface.Repositories
{
    public interface IRepository <T> where T : class
    {
        IEnumerable<T> GetAll();

        void Add(T entity);

        void Remove(string id);

        void Update(T entity);

        
    }
}
