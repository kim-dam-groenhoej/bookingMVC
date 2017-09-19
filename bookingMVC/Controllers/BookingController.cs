using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bookingMVC.Models;
using bookingMVC.ViewModels;

namespace bookingMVC.Controllers
{
    public class BookingController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Booking
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Book()
        {
            var vm = new BookVM();

            var roomGroups = this.db.Rooms.GroupBy(r => r.RoomCount).ToList();
            vm.PossibleRooms = roomGroups.Select(grp => grp.FirstOrDefault()).ToList();

            //var controller = new BusinessLogic.BookingController();
            //var isFree = controller.IsRoomAvailable(new Room(), DateTime.Now, DateTime.Now.AddDays(1));

            return View(vm);
        }
    }
}