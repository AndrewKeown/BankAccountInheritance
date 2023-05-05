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


        public double Withdraw(double amount)
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
}
