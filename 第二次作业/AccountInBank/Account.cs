using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInBank
{
    // Define a class for the Account
    public class Account
    {
        // Fields
        private decimal balance;
        public string accountNumber;
        public string password;
        public Account(string accountNumber, string password)
        {
            this.accountNumber = accountNumber;
            this.password = password;
        }
        // Properties
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        // Methods
        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        // Methods
        public virtual void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                throw new InsufficientFundsException("Insufficient funds in the account.");
            }

            balance -= amount;
        }
    }

    // Define a class for the BigMoneyArgs
    public class BigMoneyArgs : EventArgs
    {
        // Properties for account and withdrawal amount
        public Account Account { get; }
        public decimal WithdrawalAmount { get; }

        // Constructor to initialize the properties
        public BigMoneyArgs(Account account, decimal withdrawalAmount)
        {
            Account = account;
            WithdrawalAmount = withdrawalAmount;
        }
    }

    // Define a custom exception for bad cash
    public class BadCashException : Exception
    {
        public BadCashException(string message) : base(message)
        {
        }
    }

    // Define a class for the ATM
    public class ATM
    {
        // Event for big money fetched
        public event EventHandler<BigMoneyArgs> BigMoneyFetched;

        // Method to withdraw money from an account
        public void WithdrawMoney(Account account, decimal amount)
        {
            if (amount > 10000)
            {
                // Trigger the BigMoneyFetched event
                OnBigMoneyFetched(account, amount);
            }

            // Withdraw the amount from the account
            account.Withdraw(amount);
        }

        // Method to handle the BigMoneyFetched event
        protected virtual void OnBigMoneyFetched(Account account, decimal amount)
        {
            // Check if there are any subscribers to the event
            if (BigMoneyFetched != null)
            {
                // Create a new instance of BigMoneyArgs
                BigMoneyArgs args = new BigMoneyArgs(account, amount);

                // Raise the event
                BigMoneyFetched(this, args);
            }
        }
    }

    // Define a class for the CreditAccount, which inherits from Account
    public class CreditAccount : Account
    {
        // Fields
        private decimal creditLimit;
        private string accountNumber;
        private string password;
        // Properties
        public decimal CreditLimit
        {
            get { return creditLimit; }
            set { creditLimit = value; }
        }
        public CreditAccount(string accountNumber, string password) : base(accountNumber, password)
        {
            //this.creditLimit = creditLimit;
            this.CreditLimit = 20000;
        }
        // Methods
        public override void Withdraw(decimal amount)
        {
            if (amount > Balance + creditLimit)
            {
                throw new InsufficientFundsException("Insufficient funds in the account.");
            }

            Balance -= amount;
        }
    }

    // Define a custom exception for insufficient funds
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message)
        {
        }
    }

}
