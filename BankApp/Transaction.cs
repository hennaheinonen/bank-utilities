using System;
namespace BankApp
{
    public class Transaction
    {
        public double Sum { get; }
        public DateTime TimesStamp { get; }

        public Transaction(double sum, DateTime timesStamp) 
        {
            Sum = sum;
            TimesStamp = timesStamp;
        }
    }

}
