using Reservation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.Repository
{
    public interface IReservationRepository
    {
       
        IEnumerable<Reserv> GetAllReservationstIsBooking(DateTime date);
        int Create(Reserv reserv);
        Reserv GetReserv(int id);
        bool Delete(int id);
        void Update(Reserv reserv);
       
    }
}
