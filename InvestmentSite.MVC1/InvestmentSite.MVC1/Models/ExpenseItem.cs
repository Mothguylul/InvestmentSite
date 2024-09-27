namespace InvestmentSite.MVC1.Models
{
    public class ExpenseItem
    {
        public int Id { get; set; }
        public int ExpenseTypeId { get; set; }
        public decimal Amount { get; set; }
    }
}
