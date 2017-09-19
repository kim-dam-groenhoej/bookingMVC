using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bookingMVC.Models;
using bookingMVC.Helpers;

namespace bookingMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controller = new BusinessLogic.BookingController();
            var isFree = controller.IsRoomAvailable(new Room(), DateTime.Now, DateTime.Now.AddDays(1));

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

         

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}