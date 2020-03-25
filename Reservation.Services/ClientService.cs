using Reservation.Data;
using Reservation.Entities;
using Reservation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reservation.Services
{
    public class ClientService : IClientService
    {
        private IClientRepository Repository;
        public ClientService(IClientRepository clientReposotory)
        {
            Repository = clientReposotory;
        }

        public void Create(Client client)
        {
            Repository.Create(client);
        }

        public void Delete(int id)
        {
            Repository.Delete(id);
        }

        public Client GetClient(int id)
        {
            return Repository.GetClient(id);
        }

        public IEnumerable<Client> GetAllClientIsBooking(DateTime date)
        {
           return  Repository.GetAllClientIsBooking(date);
        }
    }
}
