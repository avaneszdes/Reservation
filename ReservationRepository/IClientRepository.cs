using Reservation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.Repository
{
    public interface IClientRepository
    {
        int Create(Client client);
        Client GetClient(int id);
        IEnumerable<Client> GetAllClients();
        bool Delete(Client client);
        void Update(Client client);
      
    }
}
