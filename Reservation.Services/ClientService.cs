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
        readonly IClientRepository _repository;
        public ClientService(IClientRepository clientReposotory)
        {
            _repository = clientReposotory;
        }

        public int Create(Client client)
        {
            _repository.Create(client);
            return client.Id;
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public Client GetClient(int id)
        {
            return _repository.GetClient(id);
        }

        public IEnumerable<Client> GetAllClientIsBooking(DateTime date)
        {
           return  _repository.GetAllClientIsBooking(date);
        }
    }
}
