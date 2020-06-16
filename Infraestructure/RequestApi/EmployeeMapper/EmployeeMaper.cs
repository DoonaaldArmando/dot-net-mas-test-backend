

namespace RequestApi.EmployeeMapper
{
    public class EmployeeMaper
    {
        public static Models.Employees.Employee EmployeeDtoToEmployee(EmployeeDTO employeeDTO)
        {
            return new Models.Employees.Employee(
                employeeDTO.Id,
                employeeDTO.Name,
                employeeDTO.ContractTypeName,
                employeeDTO.RoleId,
                employeeDTO.RoleName,
                employeeDTO.RoleDescription,
                employeeDTO.HourlySalary,
                employeeDTO.MonthlySalary,
                null
            );
        }
    }
}