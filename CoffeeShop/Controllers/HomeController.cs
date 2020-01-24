﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
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
            //Use my context class to pull in my DataBase data
           

            //pass the model to view to display the data
            return View();
        }

        //need one action to load our registrationPage, also need a view 
        public IActionResult Registration()
        {
            
            return View();
        }

        // need one action to take those user inputs, and display the user name , in  anew view
        public IActionResult Summary(string username, string email, string DateOfBirth, string PhoneNumber)
        {
            //use ViewBag to hold data to be displayed 
            ViewBag.Name = username;
            ViewBag.Email = email;
            ViewBag.DateOfBirth = DateOfBirth;
            ViewBag.PhoneNumber = PhoneNumber;
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
