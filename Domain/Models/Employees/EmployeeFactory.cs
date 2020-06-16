namespace Models.Employees
{
    public class EmployeeFactory
    {
        public static Employee CreateEmployee(
            int id,
            string name,
            string contractTypeName,
            int roleId,
            string roleName,
            string roleDescription,
            double hourlySalary,
            double monthlySalary,
            double annualSalary)
        {
            return new Employee(
                id,
                name,
                contractTypeName,
                roleId,
                roleName,
                roleDescription,
                hourlySalary,
                monthlySalary,
                annualSalary
            );
        }
    }
}