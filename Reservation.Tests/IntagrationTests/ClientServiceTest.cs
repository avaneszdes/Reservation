using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reservation.Entities;
using Reservation.Repository;
using Reservation.Services;

namespace Reservation.Tests.IntagrationTests
{
    [TestClass]
    public class ClientServiceTest
    {
        [TestMethod]
        public void GetClient_Data_Client()
        {
            ClientRepository clientRepository = new ClientRepository();
            
            var client = new Client()
                {Name = "111", CreateDate = DateTime.Now, PhoneNumber = "1111", SurName = "111", Quantity = 111};
              
            var clientId =  clientRepository.Create(client);
            
            var service = new ClientService(new ClientRepository());
            var actual = service.GetClient(clientId);
            
            Assert.AreEqual(client.Name, actual.Name);
            Assert.AreEqual(client.Id, actual.Id);
            Assert.AreEqual(client.PhoneNumber, actual.PhoneNumber);
            Assert.AreEqual(client.SurName, actual.SurName);
            Assert.AreEqual(client.CreateDate, actual.CreateDate);
        }
        
        [TestMethod]
        public void Create_Client_Adding()
        {
            var service = new ReservationService(new ReservationRepository());
            Assert.IsNotNull(service.GetReserv(GetReservation().Id));
        }

        [TestMethod]
        public void Delete_Id_Deleting()
        {
            var service = new ReservationService(new ReservationRepository());
            Assert.AreEqual(true , service.Delete(GetReservation().Id));
           
        }

        private Reserv GetReservation()
        {
            var client = new Client()
                {Name = "111",  PhoneNumber = "1111", SurName = "111", Quantity = 111};
            var reservation = new Reserv()
                {FromReservationDate = DateTime.Now, ToReservationDate = DateTime.Now, Client = client};
            ReservationRepository repository = new ReservationRepository();
            repository.Create(reservation);
            return reservation;
        }
    }
}