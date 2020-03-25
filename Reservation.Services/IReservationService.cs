
using Reservation.Entities;
using System.Linq;

namespace Reservation.Services
{
    interface IReservationService
    {
        Enumerable<Reserv> GetReservs();
    }
}
