using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookingMVC.Models
{
    public class Order
    {
        public int id { get; set; }

        public bool IsPayed { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}