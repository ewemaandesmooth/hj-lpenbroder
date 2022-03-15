using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using DataAccessLayer.Interface;
using DataAccessLayer.Models;


namespace BusinessLayer.Implementations
{
    public class PropertyController : IPropertyController // för att nå unit of work så ska vi använda oss av interfacets IUNITOFWORk. 
    {
        private readonly IUnitOfWork unitOfWork;

        public PropertyController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void AddProperty(string street, string postcode, string city, string userID)

        {
            Property property = new Property()
            {
                Street = street,
                Postcode=postcode,
                City= city,
                UserID=userID               

            };

            unitOfWork.Properties.Add(property);

            unitOfWork.Complete();
        }
    }
}