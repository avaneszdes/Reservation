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

        public bool Delete(Client client)
        {
            Client tmp = _context.Clients.FirstOrDefault(x => x.Name == client.Name & x.SurName == client.SurName
            & x.PhoneNumber == client.PhoneNumber & x.Id == client.Id);
            if (tmp != null)
            {
                Reserv reserv = _context.Reservs.Find(tmp.Id);
                _context.Clients.Remove(tmp);
                _context.Reservs.Remove(reserv);
                _context.SaveChanges();
                return true;
            }

            return false;

         }

        public IEnumerable<Client> GetAllClients()
        {
            return _context.Clients;
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
