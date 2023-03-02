﻿namespace FinancesTracker.Entities
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime DateSpent { get; set; }

        public int BalanceId { get; set; }
        public Balance Balance { get; set; }
    }
}
