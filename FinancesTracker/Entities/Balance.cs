namespace FinancesTracker.Entities
{
    public class Balance
    {
        public int BalanceId { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpense { get; set; }
        public decimal BalanceAmount { get { return TotalIncome - TotalExpense; } }

        public ICollection<Income> Incomes { get; set; }
        public ICollection<Expense> Expenses { get; set; }
    }
}
