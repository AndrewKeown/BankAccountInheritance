using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountInheritance
{
    internal class BankAccount
    {
        public double Balance { get; private set; }

        public BankAccount() { }

        public BankAccount(double balance) { this.Balance = balance; }

        public override string ToString()
        {
            return $"Balance: {Balance}";
        }
    }
}
