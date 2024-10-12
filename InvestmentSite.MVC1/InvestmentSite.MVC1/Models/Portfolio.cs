namespace InvestmentSite.MVC1.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        
        public int UserId { get; set; }

        public virtual ICollection<IncomeItem> IncomeItems { get; set; } = new HashSet<IncomeItem>();

        public virtual ICollection<ExpenseItem> ExpenseItems { get; set; } = new HashSet<ExpenseItem>();

    }
}
