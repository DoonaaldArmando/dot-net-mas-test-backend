using Models.Employees;

namespace RestApi.MapperViewModel
{
    public class EmployeeMapperViewModel
    {
        public static EmployeeViewModel EmployeeDtoToEmployee(Employee employee)
        {
            return new EmployeeViewModel
            {
                Id = employee.Id,
                Name = employee.Name,
                ContractTypeName = employee.ContractTypeName,
                RoleId = employee.RoleId,
                RoleName = employee.RoleName,
                RoleDescription = employee.RoleDescription,
                HourlySalary = employee.HourlySalary,
                MonthlySalary = employee.MonthlySalary,
                AnnualSalary = employee.AnnualSalary.Value
            };
        }
    }
}