using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using DataAccessLayer.Interface;
using DataAccessLayer.Models;


/*Nu när vi har våra interfaces kan vi implementera controller-klasserna (i mappen Implementations).
Båda implementeringar tar en IUnitOfWork som en parameter i konstruktorn och lagrar den i en privat
variabel. Detta möjliggör att kontrollens metoder kan använda sig av IUnitOfWork och i sin tur dess
Repositories och slutligen databasen.*/

namespace BusinessLayer.Implementations
{
    public class AdController : IAdController 
    {
        private readonly IUnitOfWork unitOfWork;// För att nå unit of work så ska vi använda oss av interfacets IUNITOFWORk.  

        public AdController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
         
        public void AddAd(string adID, string title, string userID, string propertyID, float pricePerNight, string description)
        {
            Ad ad = new Ad()
            {
                AdID = adID,
                Title = title,
                UserID = userID,
               //PropertyID = propertyID
                PricePerNight = pricePerNight,
                Description = description
            };

            unitOfWork.Ads.Add(ad);

            unitOfWork.Complete();
        }

        // Vi kommer att ha fler metoder för Ads här. Tex borttagning av Ad tror vi. 



        public IEnumerable<Ad> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}