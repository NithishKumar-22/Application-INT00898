using Microsoft.AspNetCore.Mvc;
using Application.Models;
using System.Diagnostics;

namespace Application.Controllers
{
    [Log]
    public class EmployeeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RouteSelection()
        {
            return View();
        }   
        public IActionResult ForgotPassword()
        {
            return View();
        }    
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Complaints()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
                
    }
}