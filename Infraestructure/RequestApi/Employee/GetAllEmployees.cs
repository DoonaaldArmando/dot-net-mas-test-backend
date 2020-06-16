using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models.Employees;
using Newtonsoft.Json;
using RequestApi.Utilities;

namespace RequestApi.Employee
{
    public class GetAllEmployees : IGetAllEmployees
    {
        async Task<IEnumerable<Models.Employees.Employee>> IGetAllEmployees.GetAllEmployees()
        {
            var responseString = await RequestUtilities.GetRequest();
            var listEmployeeDto = JsonConvert.DeserializeObject<IEnumerable<EmployeeMapper.EmployeeDTO>>(responseString);
            return listEmployeeDto.Select(EmployeeMapper.EmployeeMaper.EmployeeDtoToEmployee);

        }
    }
}