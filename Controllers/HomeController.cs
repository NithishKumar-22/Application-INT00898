using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Application.Models;
using System.Net.Http;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text;


namespace Application.Controllers
{
    [Log]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }
        // [HttpGet]
        // public IActionResult AdminLogin(Admin admin)
        // {
        //     Repository repository=new Repository();
        //     int temp=repository.SignInAdmin(admin);
        //     if(temp==1)
        //         return RedirectToAction("Index","Admin");
        //     else
        //         ViewBag.Message="Invalid AdminID/Password";
        //         return View();
        // }

        public IActionResult ForgotPassword()
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