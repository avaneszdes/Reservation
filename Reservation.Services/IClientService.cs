using Reservation.Data;
using Reservation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.Services
{
    interface IClientService
    {
        void Delete(int id);
        public Client GetClient(int id);
        void Create(Client client);

        IEnumerable<Client> GetAllClientIsBooking(DateTime date);


    }


}
