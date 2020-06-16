using System;
using System.Threading.Tasks;
using Models.Employees;
using Services.Utils;

namespace Services
{
    public class GetEmployeeUseCase : IGetEmployeeUseCase
    {
        private readonly IGetEmployee IGetEmployee;
        public GetEmployeeUseCase(IGetEmployee getEmployee) => IGetEmployee = getEmployee;

        public async Task<Employee> GetEmployee(int id)
        {
            Employee employee = await IGetEmployee.GetEmployee(id);

            if (employee == null)
                return null;

            return EmployeeFactory.CreateEmployee(
                    employee.Id,
                    employee.Name,
                    employee.ContractTypeName,
                    employee.RoleId,
                    employee.RoleName,
                    employee.RoleDescription,
                    employee.HourlySalary,
                    employee.MonthlySalary,
                    EmployeeUseCasesUtils.CalculateAnnualSalary(employee)
                );
        }

    }
}
