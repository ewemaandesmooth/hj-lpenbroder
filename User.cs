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
    public class User
    {
        [Key] public int Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Password {get; set;}
        public string PhoneNumber {get; set;}


        public bool VerifyPassword(string givenPassword)
        {
            return Password == givenPassword;
        }

      
    }
}
