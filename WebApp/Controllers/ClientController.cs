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
    public class ClientController : Controller
    {
        private readonly ILogger<ClientController> _logger;
        private readonly IClientService _clientService;
        public ClientController(ILogger<ClientController> logger,IClientService clientService)
        {
            _clientService = clientService;
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
        public IActionResult Create(Client client)
        {
            _clientService.Create(client);
           return RedirectToAction("Success", "Home");
        }
        
        [HttpGet]
        public IActionResult DeleteClient()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Delete(Client client)
        {
            if (_clientService.Delete(client))
            {
                return RedirectToAction("Success","Home" );
            }
            return RedirectToAction("DeleteClient");
        }
        
        
       
    }
}