using Microsoft.AspNetCore.Mvc;
using OCPI.Versioning;

namespace OCPI.Net.Sample.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    [OcpiEndpoint(ModuleId.Credentials, InterfaceRole.Receiver)]
    [OcpiVersion("2.2")]
    [OcpiVersion("2.2.1")]
    public class CredentialsController : ControllerBase
    {
        // TODO: Implement sample credentials controller
    }
}