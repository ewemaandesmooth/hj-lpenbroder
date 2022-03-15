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
    public class FacilityController : IFacilityController // För att nå unit of work så ska vi använda oss av interfacets IUNITOFWORk. 
    {
        private readonly IUnitOfWork unitOfWork;

        public FacilityController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void AddFacility(string facilityID)
        {
            Facility facility = new Facility()
            {
                //FacilityID = facilityID
            };


                unitOfWork.Facilities.Add(facility);

            unitOfWork.Complete();
        }
    }
}


