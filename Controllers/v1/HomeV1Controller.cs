using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Linq;

namespace net_core_api_versioning.Controllers.v1
{
    [Route("api/v{version:apiVersion}/home")]
    public class HomeV1Controller : BaseV1Controller
    {
        public HomeV1Controller()
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            object version = this.HttpContext.Request.RouteValues.FirstOrDefault(x=>x.Key == "version").Value;
            return new JsonResult(version);
        }
    }
}
