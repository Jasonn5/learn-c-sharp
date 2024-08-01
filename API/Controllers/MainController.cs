using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace API.Controllers
{
    [Route("api/v1/hello_world")]
    public class MainController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Persona> Get() 
        { 
            Persona persona = new Persona();
            persona.Name = "Pedro";
            persona.Age = 30;
            return Ok(persona);
        }
    }


    public class Persona 
    {
        public string Name { get; set; }
        public int Age { get; set; }  
    }
}
