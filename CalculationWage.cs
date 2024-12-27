using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalcApp
{
    internal class CalculationWage
    {

        private const int FULL_DAY_HOUR = 8;
        private const int PART_TIME_HOUR = 4;  // for part time it is 4hrs
        private const int WAGE_PER_HOUR = 20;
        private const int WORKING_DAYS_PER_MONTH = 20;

        public double CalculateEmployeeWagePerDay(Employee emp)
        {
            emp.IsPresent = IsEmployeePresent();

            if (!emp.IsPresent)
            {
                Console.WriteLine(" Employee absent today so no wage ");
                return 0.0;
            }

            Console.WriteLine(" Employee present today and employee is "+ emp.Type);
            switch (emp.Type)
            {
                case EmployeeType.FullTime:
                    Console.WriteLine($"{emp.Name} of full time employee gets wage of a day as {WAGE_PER_HOUR * FULL_DAY_HOUR}");
                    return WAGE_PER_HOUR * FULL_DAY_HOUR;

                case EmployeeType.PartTime:
                    Console.WriteLine($"{emp.Name} of part time employee gets wage of a day as {WAGE_PER_HOUR * PART_TIME_HOUR}");
                    return WAGE_PER_HOUR * PART_TIME_HOUR;

                default:
                    throw new Exception("Invalid employee type");
            }

        }
        public bool IsEmployeePresent()
        {
            Random r = new Random();
            if (r.Next(0, 2) == 1) return true;
            return false;
        }

        public double CalculateWagePerMonth(Employee emp)
        {
            double TotalWagePerMonth = 0.0;
            for (int i = 1; i <= WORKING_DAYS_PER_MONTH; i++)
            {
                Console.WriteLine(i + " day :");
                TotalWagePerMonth += CalculateEmployeeWagePerDay(emp);
            }
            return TotalWagePerMonth;
        }
        public double CalculateTillWorkingHours(Employee emp)
        {
            int remainingWorkingHours = 100;
            double totalWage = 0.0;
            int daysWorked = 0;

            while (daysWorked < WORKING_DAYS_PER_MONTH && remainingWorkingHours > 0)
            {
                emp.IsPresent = IsEmployeePresent();

                if (emp.IsPresent)
                {
                    int todayWorkingHours = (emp.Type == EmployeeType.FullTime) ? FULL_DAY_HOUR : PART_TIME_HOUR; // 8 HOURS

                    if (remainingWorkingHours < todayWorkingHours)  // remaining = 5 ,so 5 < 8
                        todayWorkingHours = remainingWorkingHours;      //   todayworkinghours = remainingHoursleft

                    totalWage += WAGE_PER_HOUR * todayWorkingHours;
                    remainingWorkingHours -= todayWorkingHours;
                    daysWorked++;
                }
            }
            return totalWage;
        }
    }
}
