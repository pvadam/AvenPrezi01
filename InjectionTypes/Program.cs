using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InjectionTypes
{
    public class Program
    {
        public void Main(string[] args)
        {
            // Constructor injection
            Console.WriteLine();
            Employee employee1
                = new Employee(new LoggerOne());

            Console.WriteLine();
            Employee employee2
                = new Employee(new LoggerTwo());

            // Setter/property injection
            Console.WriteLine();
            var job = new Job();
            job.SetLogger(new LoggerOne());
            job.Display();
            
            Console.WriteLine();
            var newJob = new Job();
            newJob.SetLogger(new LoggerTwo());
            newJob.Display();
        }
    }
}