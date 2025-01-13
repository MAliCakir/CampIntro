using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class MortgageLoan : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage loan payment plan calculated and informed");
        }
    }
}
