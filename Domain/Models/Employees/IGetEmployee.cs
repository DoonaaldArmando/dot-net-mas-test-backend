using System.Threading.Tasks;

namespace Models.Employees
{
    public interface IGetEmployee
    {
        Task<Employee> GetEmployee(int id);
    }
}