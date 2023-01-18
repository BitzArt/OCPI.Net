using Microsoft.AspNetCore.Mvc;

namespace OCPI.Net.Sample.Controllers;

[ApiController]
[Route("[Controller]")]
[OcpiEndpoint(ModuleId.Credentials, InterfaceRole.Receiver, "2.2; 2.2.1")]
public class CredentialsController : OcpiControllerBase
{
    // TODO: Implement sample credentials controller
}