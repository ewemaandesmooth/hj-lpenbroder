using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DataAccessLayer.Implementations.Repository;
using DataAccessLayer.Interface;
using System.Data.Entity;
using System.Data.SqlClient;
using DataAccessLayer.Implmentation.Repository;
using DataAccessLayer;



/*Skapat en DbContext-implementering för applikation som ärver från DbContext.
 * Lägg till de alla DbSet:en och skickar med följande connectionstring via konstruktorn 
*/

namespace DataAccessLayer
{
    // våran databas
    public class MyDbContext : DbContext

    {
        public DbSet<Ad> Ads { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public virtual DbSet<OurDiagram> OurDiagrams { get; set; }

        // Koppling till databas
        public MyDbContext() : base("MyDbConnection") // ändrat utefter johannes kommentar
        {
            
        }

       
       }
        }









        

