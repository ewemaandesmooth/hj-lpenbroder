using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DataAccessLayer.Interface;
using DataAccessLayer.Implementations.Repository;
using System.Data.Entity;
using DataAccessLayer.Interface.Repositories;
using System.Linq.Expressions;

namespace DataAccessLayer.Implmentations

/*En generisk repository har som avsikt
att implementera vanliga CRUD-operationer som delas mellan samtliga repositories och förhindrar på
så sätt duplicering av kod. I en större applikation skulle antagligen flera metoder lagts till, men för
denna demonstration räcker dessa.*/


{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        public MyDbContext dbContext = null;
        public DbSet<T> dbSet = null;

   

        public GenericRepository(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
            dbSet = dbContext.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }
        
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }
        public void Remove(string id)
        {
            T existing = dbSet.Find(id);
            dbSet.Remove(existing);
        }
        public void Update(T entity) // borde ha lista ? 
        {
            dbSet.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
        }


               
    }
}



