﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Reservation.Entities;
using Reservation.Services;
using WebApp.Models;
using WebApp.ViewModel;

namespace WebApp.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ILogger<ReservationController> _logger;
        private readonly IReservationService _reservation ;
        private readonly IClientService _clientService;
        public ReservationController(ILogger<ReservationController> logger,IReservationService reservationService,IClientService clientService )
        {
            _reservation = reservationService;
            _logger = logger;
            _clientService = clientService;
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
        
        
        [HttpGet]
        public IActionResult Reservation([FromQuery]ClientReservationViewModel clientReservationViewModel)
        {
            Reserv reserv = new Reserv();
            reserv.Client = new Client();
            reserv.FromReservationDate = clientReservationViewModel.FromReservationDate;
            reserv.ToReservationDate = clientReservationViewModel.ToReservationDate ;
            reserv.Client.Name = clientReservationViewModel.Name;
            reserv.Client.SurName = clientReservationViewModel.Surname;
            reserv.Client.Quantity = clientReservationViewModel.Quantity;
            reserv.Client.PhoneNumber = clientReservationViewModel.PhoneNumber;

            if(clientReservationViewModel.Surname == null || clientReservationViewModel.Name == null)
            {
                return Ok(-1);
            }
            else if(clientReservationViewModel.PhoneNumber == null ||  clientReservationViewModel.PhoneNumber.Length != 12  )
            {
                return Ok(-2);
            }
            else if (clientReservationViewModel.Quantity > 15)
            {
                return Ok(-3);
            }
           
            if (_reservation.CheckIfTimeIsAvailable(clientReservationViewModel.FromReservationDate,
                clientReservationViewModel.ToReservationDate))
            {
                return Ok( _reservation.Create(reserv));
            }

            return Ok(0);
        }
        
        [HttpGet]
        public IActionResult AdminLogining()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Logining(Client client)
        {
            if(client.Name == "Vlad" & client.SurName == "12345")
                return RedirectToAction("AllBookings", "Reservation");

            return RedirectToAction("AdminLogining");
        }
        
        [HttpGet]
        public IActionResult CheckIfDateIsAvailable([FromQuery]DateTime from, [FromQuery]DateTime to)
        {
            var result = _reservation.CheckIfTimeIsAvailable(from, to);

            return Ok(result);
        }
        
        [HttpGet]
        public IActionResult AllBookings()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AllBookings(DateTime dateTime)
        {
            List<Reserv> reservs = _reservation.GetAllReservationsIsBooking(dateTime).ToList();
           
            return View(reservs);
        }

        
        public IActionResult DeleteReservation([FromQuery]int id)
        {
           return Ok(_reservation.Delete(id));
        }

       

    }
}