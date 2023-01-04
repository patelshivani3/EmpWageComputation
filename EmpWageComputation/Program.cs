using System;
using System.Collections.Generic;

namespace EmpWageComputation
{
    internal class CompanyWageBuilder:ICompanyWageBuilder
    {

        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;

        //Using ArrayList
        List<CompanyEmpWage> list;
        Dictionary<string, CompanyEmpWage> dic;
        public CompanyWageBuilder()
        {
            list = new List<CompanyEmpWage>();
            dic = new Dictionary<string, CompanyEmpWage>();
        }

        public void AddComapnyDetailsIntoArray(string company, int empRatePerHrs, int maxWorkingDays, int maxWorkingHrs)
        {
            CompanyEmpWage comp = new CompanyEmpWage(company, empRatePerHrs, maxWorkingDays, maxWorkingHrs);

            list.Add(comp);
            dic.Add(company, comp);
        }

        public int GetTotalWageBasedOnCompany(string companyName)
        {
            return dic[companyName].totalEmpWage;
        }

        public void IterateOverCompany()
        {
            for (int i = 0; i < list.Count; i++)
            {
                int totalEmpWage = CalculateWage(list[i]);
                list[i].SetTotalWage(totalEmpWage);
                Console.WriteLine(list[i].ToString());
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to employee wages computation\n");
            CompanyWageBuilder builder = new CompanyWageBuilder();
            builder.AddComapnyDetailsIntoArray("Dell", 32, 25, 70);
            builder.AddComapnyDetailsIntoArray("HP", 30, 25, 75);
            builder.AddComapnyDetailsIntoArray("Lenova", 28, 25, 60);
            builder.IterateOverCompany();
            Console.WriteLine("\nGet total wages using Company Name " + builder.GetTotalWageBasedOnCompany("Dell"));
            Console.ReadLine();
        }
        public int CalculateWage(CompanyEmpWage companyDetails)
        {

            int empHrs = 0, empWage = 0, totalEmpHrs = 0, totalWorkingDays = 0, totalEmpWages = 0;
            while (totalEmpHrs <= companyDetails.maxWorkingHrs && totalWorkingDays <= companyDetails.maxWorkingDays)
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
                empWage = companyDetails.empRatePerHrs * empHrs;
                totalEmpHrs = totalEmpHrs + empHrs;
                totalEmpWages = totalEmpHrs * companyDetails.empRatePerHrs;

            }
            return totalEmpWages;
        }
    }
}    
