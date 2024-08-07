using Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System.Security.Principal;

namespace API.Controllers
{
    [Route("api/v1/hello_world")]
    public class MainController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public MainController(IEmployeeService employeeService) 
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public ActionResult<Employee> Get() 
        { 
            var persona = _employeeService.List();           
            return Ok(persona);
        }
    }



}
