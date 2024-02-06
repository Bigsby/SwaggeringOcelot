using Microsoft.AspNetCore.Mvc;

namespace ServiceOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OneController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
            => Ok("Service One");
    }
}
