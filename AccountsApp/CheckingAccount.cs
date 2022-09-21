using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    internal class CheckingAccount: Account
    {
        const double TRANSACTION_FEE = 2;
        public double Limit { get; set; }

        public CheckingAccount(int number, string name, double balance, double limit):base(number, name, balance)
        {
            Limit = limit;
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
