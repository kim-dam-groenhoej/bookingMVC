using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookingMVC.Models
{
    public class RoomPrice
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public Room Room { get; set; }
    }
}