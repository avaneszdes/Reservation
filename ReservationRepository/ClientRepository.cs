using Reservation.Data;
using Reservation.Entities;
using System;
using System.Collections.Generic;

namespace Reservation.Repository
{
    public class ClientRepository : IClientRepository<Client>
    {
        private readonly ApplicationDbContext _context;

        public ClientRepository()
        {
            _context = new ApplicationDbContext();
        }

        public void Create(Client client)
        {
            _context.Clients.Add(client);
        }

        public void Delete(int id)
        {
            Client client = _context.Clients.Find(id);
            if (client != null) { _context.Clients.Remove(client); }
        }

        public Client GetClient(int id)
        {
            return _context.Clients.Find(id);
        }
        public IEnumerable<Client> GetAllClient()
        {
            return _context.Clients;
        }


        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Client client)
        {
            _context.Update(client);
        }
    }
}
