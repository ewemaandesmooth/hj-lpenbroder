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
    public class Reservation
    {
        public string ReservationID { get; set; }
        public string AdID { get; set; }
        public User UserReservation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalPrice { get; set; }
        
        public Property property { get; set; }
        // lägg till eventuella listor?
    }
}
