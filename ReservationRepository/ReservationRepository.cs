﻿using Reservation.Data;
using Reservation.Entities;
using System;
using System.Collections.Generic;

namespace Reservation.Repository
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ReservationRepository()
        {
            _dbContext = new ApplicationDbContext();
        }

        public void Create(Reserv reserv)
        {
            _dbContext.Reservs.Add(reserv);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
           Reserv reserv = _dbContext.Reservs.Find(id);
            if(reserv != null) { _dbContext.Reservs.Remove(reserv); }
            _dbContext.SaveChanges();
        }

        public IEnumerable<Reserv> GetAllReservs()
        {
            return _dbContext.Reservs;
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
