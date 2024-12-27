using System;

namespace EmployeeWageCalcApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculationWage calculator = new CalculationWage();

            Employee emp1 = new Employee() { Id = 1 ,Name="shankar",Type=EmployeeType.FullTime};

         //  double res = calculator.CalculateEmployeeWagePerDay(emp1);

         //   Console.WriteLine($"{emp1} getting wage per day is {res}");

            //var s = calculator.CalculateWagePerMonth(emp1);

            //Console.WriteLine($"{emp1} getting wage permonth is {s}");

            var d= calculator.CalculateTillWorkingHours(emp1);

            Console.WriteLine($"{emp1} getting wage till working of 100 hours and 20 days is is {d}");

        }
    }
}
