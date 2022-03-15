using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interface;
using DataAccessLayer.Interface.Repositories;
using DataAccessLayer.Implementations;
using DataAccessLayer.Implementations.Repository;
using System.ComponentModel.DataAnnotations;
using DataAccessLayer.Models;


namespace DataAccessLayer.Models
{
    public class Property
    {
        [Key] public int Id { get; set; }
        public string Street { get; set; }
        public string Postcode {get; set;}
        public string City { get; set; }
        public string UserID { get; set; }
        public User owner { get; set; }

        public Facility facility { get; set; }

        
    }
}
