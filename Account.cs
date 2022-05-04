using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17
{
    public class Account
    {
        public double Balance { get; set; }

        public double Interest { get; set; }

        public IAccountType AccountType { get; set; }

        public Account(double balance, double interest, IAccountType accountType)
        {
            Balance = balance;
            Interest = interest;
            AccountType = accountType;
        }

        internal void CalculateInterest()
        {
            AccountType.CalculateInterest(this);
        }
    }
}
