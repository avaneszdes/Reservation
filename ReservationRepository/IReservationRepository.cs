using Reservation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.Repository
{
    public interface IReservationRepository
    {
        IEnumerable<Reserv> GetAllReservs();
        void Create(Reserv reserv);
        Reserv GetReserv(int id);
        void Delete(int id);
        void Update(Reserv reserv);
       
    }
}
