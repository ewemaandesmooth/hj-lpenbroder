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
    public class ReservationController : IReservationController // för att nå unit of work så ska vi använda oss av interfacets IUNITOFWORk. genom att typ skriva = iunitofwork variabelnamn = iunitofwork ();
    {
        private readonly IUnitOfWork unitOfWork;

        public ReservationController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void AddReservation(string reservationID)
        {
            Reservation reservation = new Reservation()
            {
                ReservationID = reservationID
            };

            unitOfWork.Reservations.Add(reservation);

            unitOfWork.Complete();
        }
    }
}
