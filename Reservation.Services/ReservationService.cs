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
        readonly IReservationRepository _reservation;
        public ReservationService(IReservationRepository reservation)
        {
            _reservation = reservation;
        }
        public int Create(Reserv reserv)
        {
            _reservation.Create(reserv);
            return reserv.Id;
        }

        public IEnumerable<Reserv> GetAllReservationsIsBooking(DateTime date)
        {
            return  _reservation.GetAllReservationstIsBooking(date);
        }
        public bool CheckIfTimeIsAvailable(DateTime fromTime, DateTime toTime)
        {
            return !_reservation.GetAllReservations().Any(x => fromTime >= x.FromReservationDate && toTime <= x.ToReservationDate);;
        }
        public bool Delete(int id)
        {
            return _reservation.Delete(id);
        }

        public Reserv GetReserv(int id)
        {
            return _reservation.GetReserv(id);
        }
    }
}
