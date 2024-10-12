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
			ExpenseItem? expenseItem = _context.ExpenseItems.Find(id);

			return expenseItem is null ? NotFound() : View(expenseItem);
		}
	}
}
