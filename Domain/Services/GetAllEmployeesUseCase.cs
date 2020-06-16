using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models.Employees;
using Services.Utils;

namespace Services
{
    public class GetAllEmployeesUseCase : IGetAllEmployeesUseCase
    {
        private readonly IGetAllEmployees IGetAllEmployees;
        public GetAllEmployeesUseCase(IGetAllEmployees getAllEmployees) => IGetAllEmployees = getAllEmployees;

        public async Task<IEnumerable<Employee>> GetEmployee()
        {
            IEnumerable<Employee> employees = await IGetAllEmployees.GetAllEmployees();
         
            return employees.Select(employee => EmployeeFactory.CreateEmployee(
                                                    employee.Id,
                                                    employee.Name,
                                                    employee.ContractTypeName,
                                                    employee.RoleId,
                                                    employee.RoleName,
                                                    employee.RoleDescription,
                                                    employee.HourlySalary,
                                                    employee.MonthlySalary,
                                                    EmployeeUseCasesUtils.CalculateAnnualSalary(employee)
                                                )
            );
        }

    }
}