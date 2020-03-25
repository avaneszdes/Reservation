
using Reservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reservation.Services
{
    interface IReservationService
    {
        IEnumerable<Reserv> CheckIfTimeIsAvailable(DateTime fromTime,DateTime toTime);
        void Delete(int id);
        public Reserv GetReserv(int id);
        void Create(Reserv reserv);
       
    }
}
