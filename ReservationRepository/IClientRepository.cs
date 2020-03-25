using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.Repository
{
    interface IClientRepository <Client>
    {

        IEnumerable<Client> GetAllClient();
        void Create(Client client);
        Client GetClient(int id);
        void Delete(int id);
        void Update(Client client);
        void Save();
    }
}
