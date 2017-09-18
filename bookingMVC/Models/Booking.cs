using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookingMVC.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}