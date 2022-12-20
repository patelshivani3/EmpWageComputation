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
            const int MAX_WORKING_DAYS = 20;
            int empHrs = 0, empWage = 0 ,totalWage = 0,day = 0;

            //UC1 Employee is present or not
            Random random = new Random();
            int empInput = random.Next(0,3);

            //UC5 Using for loop
            for(day = 1; day <= MAX_WORKING_DAYS; day++) 
            {
                //UC4 Employee wage using switch case
                switch (empInput)
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
                totalWage = totalWage + empWage;
                Console.WriteLine("day {0} employee wage  is :{1} " ,day, empWage);
            }
            
            Console.WriteLine("Total Wage for 20 days is :{0} ", totalWage);
            Console.ReadLine();

        }


    }
}
