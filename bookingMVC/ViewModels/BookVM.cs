using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bookingMVC.Models;

namespace bookingMVC.ViewModels
{
    public class BookVM
    {
        public List<Room> PossibleRooms { get; set; }
    }
}