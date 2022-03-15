using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using DataAccessLayer.Models;

/*För att upprätthålla separations of concerns (modularitet) i systemet vill vi dela upp metoderna över
flera olika controllers istället för att använda en enda klass som vi gjort i tidigare workshops
(BusinessManager). Vi vill även att Business Layer ska “gömma” våra kontrollers bakom interfaces
för att lättare kunna upprätthålla low coupling i systemet.*/

namespace BusinessLayer.Interfaces
{
    public interface IAdController
    {
        void AddAd(string adID, string title, string userID, string propertyID, float pricePerNight, string description);
        IEnumerable<Ad> GetAll();
    }
}
