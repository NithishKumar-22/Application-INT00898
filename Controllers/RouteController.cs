using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Application.Models;

namespace Application.Controllers
{
    [Log]
    public class RouteController:Controller
    {
        public IActionResult Route1()
        {
            return View();
        }
        public IActionResult Route2()
        {
            return View();
        }
        public IActionResult Route3()
        {
            return View();
        }        
    }
}