using InvestmentSite.MVC1.Models;
using Microsoft.EntityFrameworkCore;

namespace InvestmentSite.MVC1.Database;

public class InvestmentContext : DbContext
{
    public DbSet<Portfolio> Portfolios { get; set; } = default!;

    public DbSet<IncomeItem> IncomeItems { get; set; } = default!;

    public DbSet<ExpenseItem> ExpenseItems { get; set; } = default!;

    public DbSet<IncomeType> IncomeTypes { get; set; } = default!;

    public DbSet<ExpenseType> ExpenseTypes { get; set; } = default!;

    public InvestmentContext(DbContextOptions<InvestmentContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ExpenseItem>()
            .HasOne<Portfolio>()
            .WithMany(p => p.ExpenseItems)
            .HasForeignKey(expenseItem => expenseItem.PortfolioId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<IncomeItem>()
            .HasOne<Portfolio>()
            .WithMany(p => p.IncomeItems)
            .HasForeignKey(incomeItem => incomeItem.PortfolioId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ExpenseType>()
        .HasData(new List<ExpenseType>()
        {
              new ExpenseType { Id = 1, Type = "Mortgage Payment" },
              new ExpenseType { Id = 2, Type = "Car Payment" },
              new ExpenseType { Id = 3, Type = "Other Loan Payment" },
              new ExpenseType { Id = 4, Type = "Purchase - Groceries" },
              new ExpenseType { Id = 5, Type = "Purchase - Entertainment" },
              new ExpenseType { Id = 6, Type = "Taxes" },
              new ExpenseType { Id = 7, Type = "Utilities" },
         });

        modelBuilder.Entity<IncomeType>()
            .HasData(new List<IncomeType>()
            {
                   new IncomeType { Id = 1, Type = "Salary" },
                   new IncomeType { Id = 2, Type = "Interest" },
                   new IncomeType { Id = 3, Type = "Sales", },
                   new IncomeType { Id = 4, Type = "Inheritance" },
                   new IncomeType { Id = 5, Type = "Gift" },
            });

        modelBuilder.Entity<Portfolio>()
            .HasData(new Portfolio()
            {
                Id = 1,
                UserId = 1,
            });

        modelBuilder.Entity<ExpenseItem>()
            .HasData(new List<ExpenseItem>()
            {
                    new ExpenseItem { Id = 1, PortfolioId = 1, Amount = 1600.0m, ExpenseTypeId = 1 },
                    new ExpenseItem { Id = 2, PortfolioId = 1, Amount = 180.0m, ExpenseTypeId = 2 },
            });

        modelBuilder.Entity<IncomeItem>()
            .HasData(new List<IncomeItem>()
            {
                  new IncomeItem { Id = 1, PortfolioId = 1, Amount = 2000.0m, IncomeTypeId = 1 },
                  new IncomeItem { Id = 2, PortfolioId = 1, Amount = 30.0m, IncomeTypeId = 5 },

             });
    }
}
    
