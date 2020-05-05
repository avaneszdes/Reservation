using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Reservation.Entities;
using Reservation.Repository;
using Reservation.Services;

namespace Reservation.Tests
{
    [TestClass]
    public class ClientServiceTest
    {
        [TestMethod]
        public void GetClient_Data_Client()
        {
            var mock = new Mock<IClientRepository>();
            var client = new Client() {Name = "123"};
            mock.Setup(repo => repo.GetClient(It.IsAny<int>())).Returns(client);
            var service = new ClientService(mock.Object);
            Assert.AreEqual(client, service.GetClient(22));
        }


        [TestMethod]
        public void Create_Client_Adding()
        {
            var mock = new Mock<IClientRepository>();
            var client = new Client() {Name = "vitya", Id = 1};
            mock.Setup(x => x.Create(It.IsAny<Client>())).Returns(2);
            var service = new ClientService(mock.Object);
            Assert.AreEqual(client.Id, service.Create(client));
        }

        [TestMethod]
        public void Delete_Id_Deleting()
        {
            var client = new Client() {Name = "vitya", Id = 1};
            var mock = new Mock<IClientRepository>();
            mock.Setup(x => x.Delete(client)).Returns(true);
            var service = new ClientService(mock.Object);
            Assert.AreEqual(true, service.Delete(client));
        }

        [TestMethod]
        public void GetAllClientIsBooking_Date_Clients()
        {
            var mock = new Mock<IClientRepository>();
            var client = new Client() {Name = "vitya ak"};
            var client2 = new Client() {Name = "vitya ak 47"};
            var list = new List<Client>() {client, client2};
            mock.Setup(x => x.GetAllClients()).Returns(list);
            var service = new ClientService(mock.Object);
            Assert.IsTrue(list == service.CheckIfTimeIsAvailable(DateTime.Now , DateTime.Today));
        }
    }
}