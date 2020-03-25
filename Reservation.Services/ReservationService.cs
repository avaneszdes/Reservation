using Reservation.Entities;
using Reservation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reservation.Services
{
    class ReservationService : IReservationService
    {
        readonly IReservationRepository reservation;
        public ReservationService(IReservationRepository reservation)
        {
            this.reservation = reservation;
        }

    
        public IEnumerable<Reserv> CheckIfTimeIsAvailable(DateTime fromTime, DateTime toTime)
        {
            return reservation.GetAllReservs().Where(x => x.CreateDate < fromTime && x.CreateDate > toTime);
        }

        public void Create(Reserv reserv)
        {
            reservation.Create(reserv);
        }

        public void Delete(int id)
        {
            reservation.Delete(id);
        }

        public Reserv GetReserv(int id)
        {
            return reservation.GetReserv(id);
        }

      
    }
}
