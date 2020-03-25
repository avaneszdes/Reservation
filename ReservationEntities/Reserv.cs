﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.Entities
{
    public class Reserv : BaseEntity
    {
        public int IdReserv { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ManagerName { get; set; }
        public Client Client { get; set; }
    }
}