using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
   public class EmpWageBuilderObject
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public int totalWage = 0;
        public int ratePerHr = 0;
        public int maxWorkingHr=0;
        public int maxWorkingDays = 0;
        public string company;
        public EmpWageBuilderObject(string company, int ratePerHr, int workingDays, int maxWorkingHr)
        {
            this.company = company;
            this.ratePerHr = ratePerHr;
            this.maxWorkingDays = workingDays;
            this.maxWorkingHr = maxWorkingHr;
        }
        public void CalculateEmpWage()
        {
            int empHrs = 0;
            int totalEmpHr = 0;
            int totalWorkingdays = 0;
            Random random = new Random();           
            while (totalEmpHr < this.maxWorkingHr && totalWorkingdays < this.maxWorkingDays)
            {
                totalWorkingdays++;
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
                totalEmpHr = totalEmpHr + empHrs;
                //Console.WriteLine(" Days  " + totalWorkingdays + "  Emp hrs is  " + empHrs);
            }
            totalWage = totalEmpHr * ratePerHr;
        }
        public string toString()
        {
            return "Total Emp wage for company " + this.company + " is " + this.totalWage;
        }

    }
}
