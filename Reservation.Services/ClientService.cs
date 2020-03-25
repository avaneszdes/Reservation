using Reservation.Data;
using Reservation.Entities;
using System;
using System.Collections.Generic;

namespace Reservation.Services
{
    public class ClientService : IClientSerice
    {
        readonly ApplicationDbContext context;
        public void Create(Client client)
        {
            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetAllClientIsBooking()
        {
            throw new NotImplementedException();
        }

        public Client GetClient(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetClients()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
