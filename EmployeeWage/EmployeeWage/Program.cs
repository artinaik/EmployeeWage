using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject bridgelabz = new EmpWageBuilderObject("bridgelabz",20,20,100);
            bridgelabz.CalculateEmpWage();
            Console.WriteLine(bridgelabz.toString());
            EmpWageBuilderObject tcs = new EmpWageBuilderObject("TCS", 10, 15, 100);
            tcs.CalculateEmpWage();
            Console.WriteLine(tcs.toString());
            Console.ReadKey();
        }
                 
    }
}
