﻿using Reservation.Data;
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

        public bool Delete(Client client)
        {
            return _repository.Delete(client);
        }

        public Client GetClient(int id)
        {
            return _repository.GetClient(id);
        }

        public IEnumerable<Client> CheckIfTimeIsAvailable(DateTime fromTime, DateTime toTime)
        {
            return _repository.GetAllClients().Where(x => x.CreateDate < fromTime && x.CreateDate > toTime);
        }
       
    }
}
