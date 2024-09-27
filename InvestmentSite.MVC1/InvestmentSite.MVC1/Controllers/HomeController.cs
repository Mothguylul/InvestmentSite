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

        // looks for the .cshtml file in Views/Home that has the name of the returned View
		public IActionResult About()
		{
			return View("About");
		}

        public IActionResult Pricing()
        {
            return View("Pricing");
        }

        public IActionResult Home()
        {
            return View("Home");
        }
	}
}