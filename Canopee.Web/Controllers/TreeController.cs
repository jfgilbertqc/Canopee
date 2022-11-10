using Microsoft.AspNetCore.Mvc;

namespace Canopee.Web.Controllers
{
    [Route("api/trees")]
    [ApiController]
    public class TreesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTrees()
        {
            return Ok();
        }
    }
}
