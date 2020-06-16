using System.Threading.Tasks;
using Models.Employees;

namespace Services
{
    public interface IGetEmployeeUseCase
    {
        Task<Employee> GetEmployee(int id);
    }
}