using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookingMVC.Models
{
    public class Room
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int RoomCount { get; set; }

        public virtual RoomPrice RoomPrice { get; set; }

        public int RoomPriceId { get; set; }

        public bool IsRoomAvailable(Room room, DateTime start, DateTime end)
        {


            return true;
        }
    }
}