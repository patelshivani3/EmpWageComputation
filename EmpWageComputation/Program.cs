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
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0;

            Random random = new Random();
            int empInput = random.Next(0,2);

            //UC1 Check employee is present or absent
            if (IS_PRESENT == empInput)
            {
                Console.WriteLine("\nEmployee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("\nEmployee is Absent");
                empHrs = 0;
            }
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee daily wage is : "+empWage);
            Console.ReadLine();
        }
    }
}
