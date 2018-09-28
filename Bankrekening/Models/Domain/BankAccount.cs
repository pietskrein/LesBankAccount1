using System;

namespace BankingA1.Models.Domain
{
    public class BankAccount
    {

        #region Fields
        //private string _accountNumber;
        //const is sowieso static
        public const decimal WithdrawCost = 0.10M;
        private decimal _balance;
        #endregion

        #region Extra
        //public decimal GetBalance()
        //{
        //    return _balance;
        //}

        //private void SetBalance(decimal value)
        //{
        //    _balance = value;
        //}

        //Onderstaande lijn is gelijk aan alle voorgaande code 
        //public decimal Balance { get; private set; } 
        #endregion

        #region Properties
        public string AccountNumber { get; private set; }
        public decimal Balance
        {
            get
            {
                return _balance;
            }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("No negative balance allowed");
                _balance = value;
            }
        }
        #endregion

        //ctrl+k+s om regions te definieren
        #region Constructors

        public BankAccount()
        {

        }
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
        }

        //Andere constructor aanroepen
        public BankAccount(string accountNumber, decimal balance) : this(accountNumber)
        {
            Balance = balance;
        }
        #endregion

        #region Methods
        //Bevat optionele parameter
        public void Deposit(decimal amount, int nrOfTime = 1)
        {
            Balance += amount * nrOfTime;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount + WithdrawCost;
        }
        #endregion
    }
}
