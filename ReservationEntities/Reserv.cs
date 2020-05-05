using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Reservation.Entities
{
    public class Reserv : BaseEntity
    {
       
        [DataType(DataType.Date)]
        public DateTime ReservationDate { get; set; }
        public string ManagerName { get; set; }
        public Client Client { get; set; }
    }
}
