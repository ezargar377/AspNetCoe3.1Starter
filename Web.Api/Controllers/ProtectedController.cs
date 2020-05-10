using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    [Authorize /*(Policy = "ApiUser")*/]
    [Route("api/[controller]")]
    [ApiController]
    public class ProtectedController : ControllerBase
    {
        // GET api/protected/home
        [HttpGet]
        public IActionResult Home()
        {
            return new OkObjectResult(new { result = true });
        }
        
        [HttpGet("[action]")]

        [Authorize (Policy = "ApiUser")]
        public IActionResult ApiUserPolicy()
        {
            return new OkObjectResult(new { result = true });
        }
    }
}
