using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace net_core_api_versioning.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/home")]
    public class HomeV2Controller : BaseV2Controller
    {
        public HomeV2Controller()
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            object version = this.HttpContext.Request.RouteValues.FirstOrDefault(x => x.Key == "version").Value;
            return new JsonResult(version);
        }
    }
}
