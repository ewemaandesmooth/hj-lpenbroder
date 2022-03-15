using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DataAccessLayer.Implementations;

namespace BusinessLayer.Interfaces
    {
        public interface IPropertyController
        {
            void AddProperty(string street, string postcode, string city, string userID);
        }
    }
