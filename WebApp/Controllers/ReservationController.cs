using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Reservation.Entities;
using Reservation.Services;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ILogger<ReservationController> _logger;
        private readonly IReservationService _reservation ;
        public ReservationController(ILogger<ReservationController> logger,IReservationService reservationService )
        {
            _reservation = reservationService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
        
        
        [HttpPost]
        public IActionResult GetReservation(Reserv reservation)
        {
            _reservation.Create(reservation);
            return RedirectToAction("Success", "Home");
        }
    }
}