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


        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public double Balance { get; private set; }

        public BankAccount() { }

        public BankAccount(string accountNumber,double balance)
        {
            this.Balance = balance;
            this._accountNumber = accountNumber;
        }

        public override string ToString()
        {
            return $"Balance: {Balance}";
        }
    }
}
