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
        const int EMP_RATE_PER_HR = 20;
        const int MAX_WORKING_DAYS = 20;
        const int MAX_WORKING_HRS = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Employee Wage Computation");
            CalculateWage();       
            Console.ReadLine();
        }
        public static void CalculateWage()
        {
            int empHrs = 0, empWage = 0, totalWage = 0, day = 1, totalHrs = 0;

            //UC1 Employee is present or not
            Random random = new Random();


            //UC5 Using for loop
            while (day <= MAX_WORKING_DAYS && totalHrs <= MAX_WORKING_HRS)
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
                empWage = EMP_RATE_PER_HR * empHrs;
                totalWage = totalWage + empWage;
                totalHrs += empHrs;
                day++;
            }
            Console.WriteLine("Total Wage for 20 days and {0} Hours is : {1}", totalHrs, totalWage);
        }

    }
}
