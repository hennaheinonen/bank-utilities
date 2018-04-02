using System;
namespace BankApp
{
    public class Customer
    {
        public string AccountNumber { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public Customer(string accountNumber, string firstName, string lastName) 
        {
            AccountNumber = accountNumber;
            FirstName = firstName;
            LastName = lastName;

        }
        //public string AccountNumber
      //  {
        //    get { return AccountNumber; }
          //  set { AccountNumber = value; }
       // }

        public override string ToString()
        {
            return $"{FirstName} {LastName}\t{AccountNumber}";
        }
    }

}
