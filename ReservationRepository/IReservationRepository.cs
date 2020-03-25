using Reservation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.Repository
{
    interface IReservationRepository<Reserv>
    {
        IEnumerable<Reserv> GetAllReservs();
        void Create(Reserv reserv);
        Reserv GetReserv(int id);
        void Delete(int id);
        void Update(Reserv reserv);
        void Save();
    }
}
