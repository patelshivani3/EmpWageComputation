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
            
            const int PART_TIME = 1;
            const int FULL_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0;

            Random random = new Random();
            int empInput = random.Next(0,3);

            //UC4 Employee wage using switch case
            switch(empInput)
            {
                case FULL_TIME:
                    empHrs = 8;
                    Console.WriteLine("\nEmployee is FullTime Present");
                    break;

                case PART_TIME:
                    empHrs = 4;
                    Console.WriteLine("\nEmployee is PartTime Present");
                    break;

                default:
                    empHrs = 0;
                    Console.WriteLine("\nEmployee is Absent");
                    break;

            }
            //UC2 Employee daily wage 
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee daily wage is : "+empWage);
            Console.ReadLine();
        }
    }
}
