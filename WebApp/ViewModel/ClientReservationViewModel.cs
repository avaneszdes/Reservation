using System;
using System.Collections.Generic;
using Reservation.Data;
using Reservation.Entities;
using Reservation.Repository;
using Reservation.Services;

namespace WebApp.ViewModel
{
    public class ClientReservationViewModel
    {
        public List<Client> Clients { get; set; }
        public Client Client { get; set; }
    }
}