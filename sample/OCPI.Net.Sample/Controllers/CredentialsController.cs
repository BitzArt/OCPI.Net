using Microsoft.AspNetCore.Mvc;
using OCPI.Versioning;

namespace OCPI.Net.Sample.Controllers
{
    [ApiController]
    [OcpiEndpoint(ModuleId.Credentials, InterfaceRole.Receiver)]
    [Route("[controller]")]
    [ApiVersion("2.2")]
    [ApiVersion("2.2.1")]
    public class CredentialsController : ControllerBase
    {
        // TODO: Implement sample credentials controller
    }
}