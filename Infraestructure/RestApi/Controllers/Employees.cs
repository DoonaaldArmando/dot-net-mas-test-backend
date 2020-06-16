using System.Net.Mime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.Employees;
using Services;
using RestApi.MapperViewModel;
using Microsoft.AspNetCore.Cors;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IGetAllEmployeesUseCase IGetAllEmployeesUseCase;
        private readonly IGetEmployeeUseCase IGetEmployeeUseCase;

        public EmployeesController(
            IGetAllEmployeesUseCase getAllEmployeesUseCase,
            IGetEmployeeUseCase getEmployeeUseCase
        )
        {
            IGetAllEmployeesUseCase = getAllEmployeesUseCase;
            IGetEmployeeUseCase = getEmployeeUseCase;
        }


        [HttpGet]
        public async Task<IEnumerable<EmployeeViewModel>> Get()
        {
            var response = await IGetAllEmployeesUseCase.GetEmployee();
            return response.Select(EmployeeMapperViewModel.EmployeeDtoToEmployee);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetbyId(int id)
        {
            var response = await IGetEmployeeUseCase.GetEmployee(id);

            if (response == null)
                return NotFound();

            return Ok(EmployeeMapperViewModel.EmployeeDtoToEmployee(response));
        }


    }
}
