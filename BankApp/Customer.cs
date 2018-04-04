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
       
        public override string ToString()
        {
            return $"{FirstName} {LastName}\t{AccountNumber}";
        }
    }

}
