using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class Program
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int workingDays = 20;
        static void Main(string[] args)
        {
            Random random = new Random();
           
            int empWage = 0;
            int ratePerHr = 20;
            int empHrs = 0;
            int totalWage = 0;
            for (int day = 1; day <= workingDays; day++)
            {
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case isFullTime:
                        empHrs = 8;
                        break;
                    case isPartTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * ratePerHr;
                totalWage = totalWage + empWage;
                Console.WriteLine("Employee Wage is " + empWage);
            }
            Console.WriteLine("Total Employee wage is " + totalWage);
            Console.ReadKey();
        }
    }
}
