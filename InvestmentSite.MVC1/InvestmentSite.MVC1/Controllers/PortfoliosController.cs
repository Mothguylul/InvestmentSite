using InvestmentSite.MVC1.Database;
using InvestmentSite.MVC1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvestmentSite.MVC1.Controllers
{
    public class PortfoliosController : Controller
    {
        private InvestmentContext _context;

        public PortfoliosController(InvestmentContext investmentContext)
        {
            _context = investmentContext;
        }

        public IActionResult DisplayPortfolio()
        {
            Portfolio? portfolio = _context.Portfolios
                                    .Include(p => p.ExpenseItems)
                                       .ThenInclude(e => e.ExpenseType)
                                    .Include(p => p.IncomeItems)
                                       .ThenInclude(i => i.IncomeType)
                                    .Where(p => p.Id == 1)
                                    .FirstOrDefault();

            if (portfolio is null)
            {
                return NotFound();
            }

            return View(portfolio);
        }

    }
}
