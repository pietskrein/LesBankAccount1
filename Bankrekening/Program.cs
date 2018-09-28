using BankingA1.Models.Domain;
using System;

namespace BankingA1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object initializer
            //BankAccount anotherBA = new BankAccount()
            //{
            //    AccountNumber = "123-123-12-99",
            //    Balance = 200
            //};

            BankAccount myBa = new BankAccount("123-12312312-99");
            Console.WriteLine($"Account number is {myBa.AccountNumber}");
            Console.WriteLine($"Withdraw cost is {BankAccount.WithdrawCost}");
            Console.WriteLine($"Balance is {myBa.Balance} Euro");
            myBa.Deposit(200);
            Console.WriteLine($"Balance is {myBa.Balance} Euro");
            myBa.Withdraw(50);
            Console.WriteLine($"Balance is {myBa.Balance} Euro");
            Console.ReadKey();
        }
    }
}
