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
            EmpWageBuilderObject dell = new EmpWageBuilderObject("Dell", 32, 25, 70);
            dell.CalculateWage();
            Console.WriteLine(dell.ToString());
            EmpWageBuilderObject hp = new EmpWageBuilderObject("HP", 30, 25, 75);
            hp.CalculateWage();
            Console.WriteLine(hp.ToString());
            EmpWageBuilderObject lenova = new EmpWageBuilderObject("Lenova", 28, 25, 60);
            lenova.CalculateWage();
            Console.WriteLine(lenova.ToString());
            Console.ReadLine();

        }
    }
}
