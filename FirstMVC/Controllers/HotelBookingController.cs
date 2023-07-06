using Microsoft.AspNetCore.Mvc;
using FirstMVC.Models;
using System.ComponentModel.Design.Serialization;

namespace FirstMVC.Controllers
{
    public class HotelBookingController : Controller
    {
        public static List<HotelBooking> bookings = new List<HotelBooking>();
        public IActionResult Index()
        {
            return View(bookings);
        }

        public IActionResult Create()
        {
            var hb = new HotelBooking();
            return View(hb);
        }

        public IActionResult CreateForm(HotelBooking hotelBooking)
        {
            bookings.Add(hotelBooking);
            return RedirectToAction(nameof(Index));
        }

    }
}
