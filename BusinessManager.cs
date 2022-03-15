using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataAccessLayer.Models;
using DataAccessLayer;

namespace BusinessLayer.Implementations
{
    public class BusinessManager
    {
       DataManager dataManager = new DataManager();
       public void RegisterUser (User user)
        {
            dataManager.RegisterUser(user);
        }
    
    }
}
