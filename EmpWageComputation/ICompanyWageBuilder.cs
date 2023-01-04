using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    internal interface ICompanyWageBuilder
    {
        int GetTotalWageBasedOnCompany(string componyName);
        void AddComapnyDetailsIntoArray(string company, int empRatePerHrs, int maxWorkingDays, int maxWorkingHrs);
    }
}
