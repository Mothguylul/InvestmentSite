using InvestmentSite.MVC1.Database;
using InvestmentSite.MVC1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace InvestmentSite.MVC1.Controllers
{
    public class ExpenseItemsController : Controller
    {
        private readonly InvestmentContext _context;

        public ExpenseItemsController(InvestmentContext context)
        {
            _context = context;
        }

        public IActionResult GetExpenseItem(int id)
        {
            ExpenseItem? findId = _context.ExpenseItems.Where(e => e.Id == id).FirstOrDefault();

            return View("GetExpenseItem");
                   
        }
    }
}
