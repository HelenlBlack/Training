using System;
using classes;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("BankAccountHLB", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
        }
    }
}
