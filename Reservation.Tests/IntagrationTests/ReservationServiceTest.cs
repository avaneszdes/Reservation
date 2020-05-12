using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reservation.Entities;
using Reservation.Repository;
using Reservation.Services;

namespace Reservation.Tests.IntagrationTests
{
    [TestClass]
    public class ResrvationServiceTest
    {
        [TestMethod]
        public void CheckIfTimeIsAvailable_TwoDates_BooleanType()
        {
            var service = new ReservationService(new ReservationRepository());
            var tmp = GetReservation();
            Assert.IsFalse(service.CheckIfTimeIsAvailable(tmp.FromReservationDate, tmp.ToReservationDate));
            Assert.IsTrue(service.CheckIfTimeIsAvailable(new DateTime(2020, 05, 12, 13, 2, 13),
                new DateTime(2020, 05, 12, 13, 45, 13)));
        }

        [TestMethod]
        public void GetAllReservationsIsBooking_Date_Reservations()
        {
            var service = new ReservationService(new ReservationRepository());
            var reservation = GetReservations();
            Assert.IsTrue(service.GetAllReservationsIsBooking(reservation.FromReservationDate).Count() == 2);
        }

        [TestMethod]
        public void Remove_Id_BooleanType()
        {
            var service = new ReservationService(new ReservationRepository());
            var reservation1 = GetReservation();
            Assert.IsTrue(service.Delete(reservation1.Id));
        }


        [TestMethod]
        public void GetReservation_Id_Reservation()
        {
            var service = new ReservationService(new ReservationRepository());
            var reservation1 = GetReservation();
            Assert.IsTrue( service.Delete(reservation1.Id));
            Assert.IsFalse( service.Delete(reservation1.Id));
        }

        private Reserv GetReservation()
        {
            var client = new Client()
            {
                Name = "AAA", PhoneNumber = "777", SurName = "BBB", Quantity = 10
            };
            var reservation = new Reserv()
            {
                FromReservationDate = new DateTime(2020, 06, 12, 13, 2, 13),
                ToReservationDate = new DateTime(2020, 06, 12, 13, 45, 13),
                Client = client
            };
            ReservationRepository repository = new ReservationRepository();
            repository.Create(reservation);
            return reservation;
        }
        
        private Reserv GetReservations()
        {
            var client = new Client()
            {
                Name = "AAA", PhoneNumber = "777", SurName = "BBB", Quantity = 10
            };
            var reservation = new Reserv()
            {
                FromReservationDate = new DateTime(2020, 06, 15, 13, 2, 13),
                ToReservationDate = new DateTime(2020, 06, 12, 13, 45, 13),
                Client = client
            };
            var client2 = new Client()
            {
                Name = "ABC", PhoneNumber = "777", SurName = "BBB", Quantity = 10
            };
            var reservation2 = new Reserv()
            {
                FromReservationDate = new DateTime(2020, 06, 15, 13, 2, 13),
                ToReservationDate = new DateTime(2020, 06, 12, 13, 45, 13),
                Client = client
            };
            ReservationRepository repository = new ReservationRepository();
            repository.Create(reservation);
            repository.Create(reservation2);
            return reservation;
        }
    }
}