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
   public class Facility
    {
        // kan behöva en [KEY] här
        [Key] public int Id { get; set; }
        public bool Discoroom { get; set; } //= new Facility() { Name = Discoroom};
        public bool OpenBar { get; set;}// = new Facility() { Name = OpenBar};
        public bool SmokeMachine { get; set; }//= new Facility() {Name = SmokeMachine};
        public bool DanceFloor { get; set; } //= new Facility() { Name = DanceFloor};

    }
}
