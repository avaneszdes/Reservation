using Reservation.Data;
using Reservation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.Services
{
    public interface IClientService
    {
        bool Delete(Client client);
        Client GetClient(int id);
        int Create(Client client);
    }
}