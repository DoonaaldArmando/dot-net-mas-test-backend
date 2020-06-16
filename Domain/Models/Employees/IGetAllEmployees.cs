using System.Threading.Tasks;
using System.Collections.Generic;

namespace Models.Employees
{
    public interface IGetAllEmployees
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
    }
}