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
            Random random = new Random();
            int isFullTime = 1;
            int empWage = 0;
            int ratePerHr = 20;
            int empHrs = 0;
            int empcheck = random.Next(0, 2);
            if (empcheck==isFullTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * ratePerHr;
            Console.WriteLine("Employee Wage is " + empWage);
            Console.ReadKey();
        }
    }
}
