using Reservation.Data;
using Reservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Reservation.Repository
{
    public class ReservationRepository : IReservationRepository
    {
         readonly ApplicationDbContext _dbContext;
        public ReservationRepository()
        {
            _dbContext = new ApplicationDbContext();
        }

        public int Create(Reserv reserv)
        {
            _dbContext.Reservs.Add(reserv);
            _dbContext.SaveChanges();
            return reserv.Id;
        }

        public bool Delete(int id)
        {
           Reserv reserv = _dbContext.Reservs.Find(id);
           if (reserv != null)
           {
               _dbContext.Reservs.Remove(reserv);
               _dbContext.SaveChanges();
               return true;
           }

           return false;
        }

        public IEnumerable<Reserv> GetAllReservationstIsBooking(DateTime date)
        {
            return _dbContext.Reservs.Where(x => x.ReservationDate == date).Include(c => c.Client);
        }

       

        public Reserv GetReserv(int id)
        {
            return _dbContext.Reservs.Find(id);
        }


        public void Update(Reserv reserv)
        {
            _dbContext.Reservs.Update(reserv);
            _dbContext.SaveChanges();
        }
    }
}
