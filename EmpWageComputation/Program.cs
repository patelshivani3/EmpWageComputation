using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    internal class Program
    {
        const int PART_TIME = 1;
        const int FULL_TIME = 2;
        
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Employee Wage Computation\n");
            CalculateWage("dell", 32, 25, 70);
            CalculateWage("hp", 30, 25, 75);
            CalculateWage("lenova", 28, 25, 60);
            Console.ReadLine();
        }
        public static void CalculateWage(string company, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            int empHrs = 0, empWage = 0, totalWage = 0, day = 1, totalHrs = 0;

            //UC1 Employee is present or not
            Random random = new Random();


            //UC5 Using for loop
            while (day <= maxWorkingDays && totalHrs <= maxWorkingHrs)
            {
                int empInput = random.Next(0, 3);
                //UC4 Employee wage using switch case
                switch (empInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        break;

                    case PART_TIME:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                //UC2 Employee daily wage 
                empWage = empRatePerHr * empHrs;
                totalWage = totalWage + empWage;
                totalHrs += empHrs;
                day++;
            }
            Console.WriteLine("Total Wage of {0} for 20 days and {1} Hours is : {2}",company, totalHrs, totalWage);
        }

    }
}
