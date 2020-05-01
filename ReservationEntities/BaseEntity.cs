using System;

namespace Reservation.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
       public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
