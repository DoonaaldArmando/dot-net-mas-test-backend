using System;
using Models;
using Models.Employees;

namespace Services.Utils
{
    public class EmployeeUseCasesUtils
    {
        public static double CalculateAnnualSalary(Employee employee)
        {
            if (employee.ContractTypeName == Values.HourlySalaryEmployee.ToString())
                return 120 * employee.HourlySalary * 12;


            return employee.MonthlySalary * 12;
        }
    }
}