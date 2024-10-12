namespace InvestmentSite.MVC1.Models
{
    public class IncomeItem
    {
        public int Id { get; set; }

        public int PortfolioId { get; set; }

        public int IncomeTypeId { get; set; }

        public decimal Amount { get; set; }

        public IncomeType? IncomeType { get; set; }
    }
}
