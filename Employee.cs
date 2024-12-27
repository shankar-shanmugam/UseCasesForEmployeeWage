using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalcApp
{
    public enum EmployeeType
    {
        FullTime,
        PartTime
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPresent { get; set; }
        public EmployeeType Type { get; set; }
        public override string ToString()
        {
            return $" Employee Id :{Id}, Employee Name :{Name} ";
        }
    }
}
