using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto;
using Empleados.Models;
using Empleado.Services;

namespace Empleador.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost("Register")]
        public IActionResult RegisterEmployee([FromBody] Employee employee)
        {
            try
            {
                _employeeService.RegisterEmployee(employee);
                return Ok(new
                {
                    message = "Empleado creado con éxito"
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpGet("GetEmployees")]
        public ActionResult<IEnumerable<Employee>> GetEmployees()
        {
            try
            {
                var employees = _employeeService.GetEmployees();
                return Ok(employees);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}


