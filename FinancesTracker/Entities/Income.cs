namespace FinancesTracker.Entities
{
    public class Income
    {
        public int IncomeId { get; set; }
        public decimal Amount { get; set; }
        public string Source { get; set; }
        public DateTime DateReceived { get; set; }

        public int BalanceId { get; set; }
        public Balance Balance { get; set; }
    }
}
