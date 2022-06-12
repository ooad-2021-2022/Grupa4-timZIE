﻿using Microsoft.AspNetCore.Mvc;
using Projekat___Parking.Models;
using System.Diagnostics;

namespace Projekat___Parking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Korisnik()
        {
            return View();
        }
        public IActionResult VIPKorisnik()
        {
            return View();
        }

        public IActionResult Radnik()
        {
            return View();
        }
        public IActionResult Vlasnik()
        {
            return View();
        }



        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}