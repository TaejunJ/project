using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    internal class SavingAccount: Account
    {
        const double TRANSACTION_FEE = 3.5;

        public double Interest { get; set; }

        public SavingAccount (int number, string name, double balance, double interest):base(number, name, balance)
        {
            Interest = interest;
        }
        public override void Deposit(double amount)
        {
            Balance = Balance + amount - TRANSACTION_FEE;
        }
        public override void Withdraw(double amount)
        {
            Balance = Balance - amount - TRANSACTION_FEE;
        }
    }
}
