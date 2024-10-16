﻿namespace InvestmentSite.MVC1.Models
{
    public class ExpenseItem
    {
        public int Id { get; set; }

        public int PortfolioId { get; set; }

        public int ExpenseTypeId { get; set; }

        public decimal Amount { get; set; }

        public ExpenseType? ExpenseType { get; set; }
    }
}
