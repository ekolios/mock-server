using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RedirectionMocker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RedirectionMockController : ControllerBase
    {

        private readonly ILogger<RedirectionMockController> _logger;
        private static string location = "https://loud-kilobyte-21.webhook.cool";


        public RedirectionMockController(ILogger<RedirectionMockController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "RedirectionMock")]
        public IActionResult RedirectToNewLocation()
        {
            return Redirect(location);
        }
    }
}
