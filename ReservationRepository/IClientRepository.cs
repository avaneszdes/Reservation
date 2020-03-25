using Reservation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.Repository
{
    public interface IClientRepository
    {
        void Create(Client client);
        Client GetClient(int id);
        IEnumerable<Client> GetAllClientIsBooking(DateTime date);
        void Delete(int id);
        void Update(Client client);
      
    }
}
