using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Employee Wage Computation");
            const int IS_PRESENT = 0;

            Random random = new Random();
            int empInput = random.Next(0,2);
            
            //UC1 Check employee is present or absent
            if (IS_PRESENT == empInput)
                Console.WriteLine("\nEmployee is Present");
            else
                Console.WriteLine("\nEmployee is Absent");
            
            Console.ReadLine();
        }
    }
}
