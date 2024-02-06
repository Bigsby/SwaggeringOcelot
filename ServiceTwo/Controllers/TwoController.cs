using Microsoft.AspNetCore.Mvc;

namespace ServiceTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
            => Ok("Service Two");
    }
}
