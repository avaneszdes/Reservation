using Reservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reservation.Services
{
    interface IReservationService
    {
        IEnumerable<Reserv> CheckIfTimeIsAvailable(DateTime fromTime, DateTime toTime);
        bool Delete(int id);
        Reserv GetReserv(int id);
        int Create(Reserv reserv);
    }
}