using System.Collections.Generic;
using System.Threading.Tasks;
using Models.Employees;

namespace Services
{
    public interface IGetAllEmployeesUseCase
    {
        Task<IEnumerable<Employee>> GetEmployee();
    }
}