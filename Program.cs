using System;

namespace HW17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account accountSimple = new Account(1000, 2000, new SimpleAccountType());
            Account accountSalary = new Account(500, 1000, new SalaryAccountType());

            Calculator.CalculateInterest(accountSalary);
            Calculator.CalculateInterest(accountSimple);

            Console.WriteLine(accountSimple.Interest);
            Console.WriteLine(accountSalary.Interest);
        }
    }
}