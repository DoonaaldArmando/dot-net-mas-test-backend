using System.Linq;
using System.Collections.Generic;
using System;
using Models.Exceptions;

namespace Models.Employees
{
    public class Employee
    {
        public readonly int Id;
        public readonly string Name;
        public readonly string ContractTypeName;
        public readonly int RoleId;
        public readonly string RoleName;
        public readonly string RoleDescription;
        public readonly double HourlySalary;
        public readonly double MonthlySalary;
        public readonly double? AnnualSalary;

        private Employee() { }
        public Employee(
            int id,
            string name,
            string contractTypeName,
            int roleId,
            string roleName,
            string roleDescription,
            double hourlySalary,
            double monthlySalary,
            double? annualSalary
        )
        {
            var employeeErrors = new List<string>();

            if (string.IsNullOrWhiteSpace(name))
                employeeErrors.Add("error con Name");

            if (string.IsNullOrWhiteSpace(contractTypeName))
                employeeErrors.Add("error con ContractTypeName");


            if (
                contractTypeName.Equals(Values.HourlySalaryEmployee.ToString()) &&
                contractTypeName.Equals(Values.MonthlySalaryEmployee.ToString())
             )
                employeeErrors.Add("error con los valores ContractTypeName");

            if (string.IsNullOrWhiteSpace(roleName))
                employeeErrors.Add("error con RoleName");

            if (id < 0)
                employeeErrors.Add("error con Id");

            if (roleId < 0)
                employeeErrors.Add("error con RoleId");

            if (hourlySalary < 0)
                employeeErrors.Add("error con HourlySalary");

            if (hourlySalary < 0)
                employeeErrors.Add("error con MonthlySalary");

            if (employeeErrors.Any())
                throw new CreateEmployeeException(string.Join(", ", employeeErrors));

            Id = id;
            Name = name;
            ContractTypeName = contractTypeName;
            RoleId = roleId;
            RoleName = roleName;
            RoleDescription = roleDescription;
            HourlySalary = hourlySalary;
            MonthlySalary = monthlySalary;
            AnnualSalary = annualSalary;

        }

    }
}