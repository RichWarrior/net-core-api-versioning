using Microsoft.AspNetCore.Mvc;

namespace net_core_api_versioning.Controllers.v2
{
    [ApiVersion("2.0")]
    [ApiController]
    public class BaseV2Controller : BaseController
    {
    }
}
