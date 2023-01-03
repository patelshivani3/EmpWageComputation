using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    internal class CompanyWage
    {
        
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;

         public string company;
         public int empRatePerHour, numOfWorkingDays,maxHoursPerMonth,totalEmpWage;
         

        public CompanyWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        { 
                this.company = company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHoursPerMonth = maxHoursPerMonth;
        }
        static void Main(string[] args)
        {
            CompanyWage dell = new CompanyWage("Dell", 32, 25, 70);
            dell.CalculateWage();
            Console.WriteLine(dell.ToString());
            CompanyWage hp = new CompanyWage("HP", 30, 25, 75);
            hp.CalculateWage();
            Console.WriteLine(hp.ToString());
            CompanyWage lenova = new CompanyWage("Lenova", 28, 25, 60);
            lenova.CalculateWage();
            Console.WriteLine(lenova.ToString());
            Console.ReadLine();
        }
        public void CalculateWage()
        {

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays <= this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int employeeInput = random.Next(0, 3);
                //UC-4- Switch case
                switch (employeeInput)
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day : " + totalWorkingDays + " & Emp Hours : " + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage for Company : " + company + " is : " + totalEmpWage);
        }
    }
}
