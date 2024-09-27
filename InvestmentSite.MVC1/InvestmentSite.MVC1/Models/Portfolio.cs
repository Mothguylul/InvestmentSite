namespace InvestmentSite.MVC1.Models
{
    public class Portfolio
    {
        public int Id { get; set; } 
        public int UserID { get; set; }
        public List<IncomeItem> IncomeItems { get; set; } = new List<IncomeItem>();
        public List<ExpenseItem> ExpenseItems { get; set; } = new List<ExpenseItem>();

    }
}
