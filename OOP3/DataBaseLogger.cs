using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class DataBaseLogger : ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("logged into the database");
        }
    }
}
