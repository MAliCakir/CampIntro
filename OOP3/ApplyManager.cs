using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplyManager
    {
        //Dependencie Injection

        //method injection

        //if we will send more than 1 services we should use List<ILoggerServices>
        public void DoApply(ILoanManager loanManager,ILoggerServices loggerServices)
        {
            loanManager.Calculate();
            Console.WriteLine("Your loan has been approved");
            loggerServices.Log();
        }

        public void DoLoanInfo(List<ILoanManager> loans,ILoggerServices loggerServices)
        {
            foreach (ILoanManager loan in loans)
            {
                loan.Calculate();
            }
        }
    }
}
