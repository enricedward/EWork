﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EWork.Models;
using Microsoft.AspNetCore.Authorization;

namespace EWork.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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

        //[AllowAnonymous]
        //[Route("Home/Test")]
        //[Route("Test")]
        //public async Task<IActionResult> Test()
        //{
        //    var test = new Tests(_db);

        //    return Content((await test.Test1()).ToString());
        //}
    }
}
