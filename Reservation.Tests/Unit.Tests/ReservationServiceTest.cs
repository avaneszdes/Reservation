using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Reservation.Entities;
using Reservation.Repository;
using Reservation.Services;

namespace Reservation.Tests
{
    [TestClass]
    public class ReservationServiceTest
    {
        [TestMethod]
        public void GetReservation_Id_Reservation()
        {
            var mock = new Mock<IReservationRepository>();
            var reserv = new Reserv() {ManagerName = "Leva"};
            mock.Setup(repo => repo.GetReserv(It.IsAny<int>())).Returns(reserv);
            var service = new ReservationService(mock.Object);
            Assert.IsTrue(reserv == service.GetReserv(22));
        }


        [TestMethod]
        public void Create_ReservationObject_IdReservation()
        {
            var mock = new Mock<IReservationRepository>();
            var reserv = new Reserv() {Id = 2};
            mock.Setup(repo => repo.Create(It.IsAny<Reserv>())).Returns(22);
            var service = new ReservationService(mock.Object);
            Assert.AreEqual(reserv.Id,service.Create(reserv));
        }

        [TestMethod]
        public void Delete_Id_Deleting()
        {
            var mock = new Mock<IReservationRepository>();
            mock.Setup(repo => repo.Delete(2)).Returns(true);
            var service = new ReservationService(mock.Object);
            Assert.IsTrue(true == service.Delete(2));
        }
    }
}