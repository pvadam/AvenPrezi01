using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Program
    {
        public void Main(string[] args)
        {
            for (int i = 0; i <= 3; i++)
            {
                var position = Factory.Get(i);
                Console.WriteLine("Where id = {0}, position = {1} ", i, position.Title);
            }
        }
    }
}