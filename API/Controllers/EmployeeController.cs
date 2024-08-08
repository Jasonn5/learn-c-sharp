using Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System.Security.Principal;

namespace API.Controllers
{
    [Route("api/v1/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService) 
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public ActionResult<Employee> Get() 
        { 
            var persona = _employeeService.List();           
            return Ok(persona);
        }

        [HttpPost]
        public ActionResult<Employee> Post(Employee employee)
        {
            var newEmployee = _employeeService.Add(employee);
            return Created("Employee Crated",newEmployee);
        }

    }



}
