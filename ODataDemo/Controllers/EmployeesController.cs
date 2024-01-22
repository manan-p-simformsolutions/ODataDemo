using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using ODataDemo.Models;
using ODataDemo.Services;

namespace ODataDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private EmployeeService _employeeService;
        public EmployeesController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_employeeService.GetEmployees());
        }
    }
}
