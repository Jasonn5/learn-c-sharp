using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace API.Controllers
{
    [Route("api/v1/hello_world")]
    public class MainController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Employee> Get() 
        { 
            Employee persona = new Employee();           
            return Ok(persona);
        }
    }



}
