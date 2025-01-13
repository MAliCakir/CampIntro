using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ArtisanLoan : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("artisan loan payment plan calculated and informed");
        }
    }
}
