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

    
       

        public int Create(Reserv reserv)
        {
            reservation.Create(reserv);
            return reserv.Id;
        }

        public IEnumerable<Reserv> GetAllReservationsIsBooking(DateTime date)
        {
            return  reservation.GetAllReservationstIsBooking(date);
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
