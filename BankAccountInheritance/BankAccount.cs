using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountInheritance
{
    internal class BankAccount
    {
        string _accountNumber;
        static int countNumber = 0;

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public double Balance { get; private set; }

        public BankAccount()
        {
            Balance = 0;
            countNumber++;
            _accountNumber = countNumber.ToString();
        }

        public BankAccount(double balance)
        {
            this.Balance = balance;
            countNumber++;
            _accountNumber = countNumber.ToString();
        }

        public BankAccount(string accountNumber, double balance)
        {
            this.Balance = balance;
            this._accountNumber = accountNumber;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        /// <summary>
        /// This method withdraws the amount from the account and subtracts from the balance.
        /// If there;s not wnough money, the avalible balance is withdrawn and the balance set to 0;
        /// The amount of money avalible to withdraw is returned.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public virtual double Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return amount;
            }
            else
            {
                amount = Balance;
                Balance = 0;
            }
            return amount;
        }
        public override string ToString()
        {
            return $"Account Number : {_accountNumber} Balance: {Balance}";
        }
    }

    class CurrentAccount:BankAccount
    {
        public double OverdraftLimit { get; private set; }

        public CurrentAccount() : base()
        {
            OverdraftLimit = 0;
        }

        public CurrentAccount(double balance, double overdraftLimit):base(balance)
        {
            this.OverdraftLimit = overdraftLimit;
        }

    }
}
