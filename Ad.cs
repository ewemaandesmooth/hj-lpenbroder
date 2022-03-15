using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interface;
using DataAccessLayer.Implementations.Repository;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class Ad 
    {
        public string AdID { get; set; }
        public string Title { get; set; }
        public string UserID { get; set; }
        public Property Property { get; set; } 
        public float PricePerNight { get; set; } 
        public string Description { get; set; }
      


    }
}
