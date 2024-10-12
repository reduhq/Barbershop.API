using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Barbershop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost()]
        public ActionResult<String> Create()
        {
            return Ok("Creado");
        }

        [HttpGet()]
        public ActionResult<IEnumerable<String>> Get()
        {
            return Ok("hola");
        }
    }
}
