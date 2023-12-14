using Labos2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labos2.Controllers
{
    public class BookingController : Controller
    {
        private static List<HotelBooking> _hotelBookings = new List<HotelBooking>();
        public IActionResult Index()
        {
            return View(_hotelBookings);
        }

        public IActionResult Create()
        {
            HotelBooking booking = new HotelBooking();
            return View(booking);
        }

        public IActionResult CreateBooking(HotelBooking booking)
        {
            _hotelBookings.Add(booking);
            return RedirectToAction("Index");
        }
    }
}
