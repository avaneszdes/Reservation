using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Reservation.Entities;
using Reservation.Repository;
using Reservation.Services;

namespace Reservation.Tests.Intagration.Tests
{
    [TestClass]
    public class ClientServiceTest
    {
        [TestMethod]
        public void GetClient_Data_Client()
        {
            ClientRepository clientRepository = new ClientRepository();
            
            var client = new Client()
                {Name = "123", CreateDate = DateTime.Now, PhoneNumber = "22222", SurName = "ava"};
              
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
            var client = new Client(){Name = "123", CreateDate = DateTime.Now, PhoneNumber = "22222", SurName = "ava"};
            var service = new ClientService(new ClientRepository());

            var actual = service.Create(client);
            Assert.AreEqual(client.Id,actual);
        }

        [TestMethod]
        public void Delete_Id_Deleting()
        {
            var client = new Client()
                {Name = "123", CreateDate = DateTime.Now, PhoneNumber = "22222", SurName = "ava"};

            var service = new ClientService(new ClientRepository());
            
            Assert.AreEqual(true, service.Delete(client));
           
        }

      
    }
}