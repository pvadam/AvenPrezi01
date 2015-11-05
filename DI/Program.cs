using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI
{
    public class Program
    {
        public void Main(string[] args)
        {
            IPoint p = new Point(2, 3);
            Console.Write("My Point: ");
            PrintPoint(p);
            
            Console.ReadLine();
        }
        
        static void PrintPoint(IPoint p)
        {
            Console.WriteLine("x={0}, y={1}", p.x, p.y);
        }
    }
}