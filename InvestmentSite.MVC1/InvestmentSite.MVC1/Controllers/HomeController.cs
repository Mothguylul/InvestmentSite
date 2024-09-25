using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InvestmentSite.MVC1.Controllers
{
    public class HomeController : Controller
    {     
        public IActionResult Index()
        {
            return View();
        }   
    }
}