﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CyberCongratulator.Models;
using System.Diagnostics;

namespace CyberCongratulator.Controllers {
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
    }
}
