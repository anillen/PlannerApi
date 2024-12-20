using Microsoft.AspNetCore.Mvc;

namespace PlannerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemController : ControllerBase
    {
        /// <summary>
        /// Get state application
        /// </summary>
        /// <returns>State application</returns>
        [HttpGet]
        public IActionResult Index()
        {
            return Ok($"[{nameof(SystemController)}] is already for job");
        }
    }
}
