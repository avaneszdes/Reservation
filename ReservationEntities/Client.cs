using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.Entities
{
    public class Client : BaseEntity
    {
       
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhoneNumber { get; set; }
        
        public List<Reserv> Reservs { get; set; }
    }
}






