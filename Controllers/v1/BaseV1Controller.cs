using Microsoft.AspNetCore.Mvc;

namespace net_core_api_versioning.Controllers.v1
{
    [ApiVersion("1.0",Deprecated =false)]
    [ApiVersion("1.1")]
    [ApiController]
    public class BaseV1Controller : BaseController
    {
    }
}
