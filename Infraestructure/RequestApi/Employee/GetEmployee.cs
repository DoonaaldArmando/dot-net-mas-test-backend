using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Employees;
using Newtonsoft.Json;
using RequestApi.Utilities;

namespace RequestApi.Employee
{
    public class GetEmployee : IGetEmployee
    {

        async Task<Models.Employees.Employee> IGetEmployee.GetEmployee(int id)
        {
            var responseString = await RequestUtilities.GetRequest();
            var listEmployeeDto = JsonConvert.DeserializeObject<IEnumerable<EmployeeMapper.EmployeeDTO>>(responseString);
            return listEmployeeDto
                        .Where(b => b.Id == id)
                        .Select(EmployeeMapper.EmployeeMaper.EmployeeDtoToEmployee)
                        .FirstOrDefault();
        }
    }
}