﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AroundTheWorld.Web.Models;

namespace AroundTheWorld.Web.Controllers
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
        
        public IActionResult StartANewDiary()
        {
            return View();
        }

        public IActionResult PublicDiaries()
        {
            return View();
        }

        public IActionResult AccountSettings()
        {
            return View();
        }

        public IActionResult EditEmailAddress()
        {
            return View();
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        public IActionResult DeleteAccount()
        {
            return View();
        }

        public IActionResult EditDiary()
        {
            return View();
        }
        public IActionResult DeleteDiary()
        {
            return View();
        }

        public IActionResult Privacy()
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
