using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Reservation.Entities
{
    public class Reserv : BaseEntity
    {
       
        [DataType(DataType.Date)]
        public DateTime FromReservationDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime ToReservationDate { get; set; } 
        public Client Client { get; set; }
    }
}
