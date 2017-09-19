using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bookingMVC.Models;

namespace bookingMVC.BusinessLogic
{
    public class BookingController
    {
        // GET: Booking
        public bool IsRoomAvailable(Room room, DateTime start, DateTime end)
        {


            return true;
        }
    }
}