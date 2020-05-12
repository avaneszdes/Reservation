using Reservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reservation.Services
{
     public interface IReservationService
    {
        IEnumerable<Reserv> GetAllReservationsIsBooking(DateTime date);
        bool CheckIfTimeIsAvailable(DateTime date, DateTime dateTime2);
        bool Delete(int id);
        Reserv GetReserv(int id);
        int Create(Reserv reserv);
    }
}