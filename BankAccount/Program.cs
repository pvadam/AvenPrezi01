using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Program
    {
        public void Main(string[] args)
        {
            ILogger logger = new Logger();
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99, logger); 

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}