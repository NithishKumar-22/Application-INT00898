using Microsoft.AspNetCore.Mvc;
using Application.Models;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Application.Controllers
{   
    [Log]
    public class AdminController:Controller
    {
        public IActionResult SeatList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }      
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        } 
        public IActionResult Logout()
        {
            return View();
        }        

    }
}