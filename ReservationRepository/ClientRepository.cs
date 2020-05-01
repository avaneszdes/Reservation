using Reservation.Data;
using Reservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reservation.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly ApplicationDbContext _context;

        public ClientRepository()
        {
            _context = new ApplicationDbContext();
        }

        public int Create(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
            return client.Id;
        }

        public bool Delete(int id)
        {
            Client client = _context.Clients.Find(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
                return true;
            }

            return false;

        }

        public IEnumerable<Client> GetAllClientIsBooking(DateTime date)
        {
            return _context.Clients.Where(x => x.CreateDate == date);
        }


        public Client GetClient(int id)
        {
            return _context.Clients.Find(id);
        }

        public void Update(Client client)
        {
            _context.Update(client);
            _context.SaveChanges();
        }
    }
}
