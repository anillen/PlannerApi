using Microsoft.AspNetCore.Mvc;

namespace PlannerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok($"[{nameof(SystemController)}] is already for job");
        }
    }
}
