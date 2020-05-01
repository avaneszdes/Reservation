using Reservation.Entities;
using Reservation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reservation.Services
{
    public class ReservationService : IReservationService
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

        public int Create(Reserv reserv)
        {
            reservation.Create(reserv);
            return reserv.Id;
        }

        public bool Delete(int id)
        {
            return reservation.Delete(id);
        }

        public Reserv GetReserv(int id)
        {
            return reservation.GetReserv(id);
        }

      
    }
}
