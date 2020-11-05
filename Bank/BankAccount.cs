using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Bank
{
    public class BankAccount
    {
        //could be b/c it's (1) immutable, and (2) not ment to act like a number
        //it's more like a string label or an id, that's just made of numbers only.
        public string Number { get; }
        public string Owner { get; set; }

        //lets you varify the accuracy of the balance based on the transactions
        //and also lets you track transactions.
        //storing the balance seperately, then you have another point of failure.
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();



        public BankAccount(String accountName, decimal initBal)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            
            this.Owner = accountName;

            if( initBal < 0){
                Console.WriteLine("Initial Bal must be at least zero.");
            }
            MakeDeposit(initBal, DateTime.Now, "Initial balance");
        }



        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
             if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
         }



        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }



        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }
    }
}