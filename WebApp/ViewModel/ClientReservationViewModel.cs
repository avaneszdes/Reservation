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
        public DateTime CreateDateTime { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        
        public List<Client> Clients { get; set; }
    }
}