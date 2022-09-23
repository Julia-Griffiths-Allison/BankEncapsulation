using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;
        public double Deposit(double d)
        {
            balance = balance + d;
            return balance;
        }

        public double getBalance()
        {
            return balance;
        }

        public double Withdraw(double w)
        {
            balance = balance - w;
            return balance;

        }
    }
}
