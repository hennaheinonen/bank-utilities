using System;
using System.Collections.Generic;
using System.Linq;
namespace BankApp
{
    public class Account
    {
        private string _accountNumber;
        public double Balance { get; set; }
        private List<Transaction> _transactions;

        public Account(string accountNumber) 
        {
            _accountNumber = accountNumber;
            _transactions = new List<Transaction>();
        }
        public string AccountNumber 
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
     

        public Account(string accountNumber, double balance, List<Transaction> transaction) 
        {
            _accountNumber = accountNumber;
            Balance = balance;
            _transactions = transaction;
        }
        public bool AddTransaction(Transaction transaction) 
        {
            bool res = false;

            _transactions.Add(transaction);
            double balanceBeforeTransaction = Balance;
            if (_transactions.Last().Equals(transaction)) 
            {
                Balance += transaction.Sum;
            }
            if (Balance - transaction.Sum == balanceBeforeTransaction)
            {
                res = true;
            }

            return res;
        }
        public List<Transaction>GetTransactionsForTimeSpan(DateTime startTime, DateTime endTime) 
        {
            List<Transaction> res = (from transaction in _transactions
                                     where transaction.TimesStamp >= startTime && transaction.TimesStamp <= endTime
                                     orderby transaction.TimesStamp
                                     select transaction).ToList();
            return res;
        }
    }
}
