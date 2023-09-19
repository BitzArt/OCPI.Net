using Microsoft.AspNetCore.Mvc;
using OCPI.Contracts;

namespace OCPI.Sample.Controllers;

[OcpiEndpoint(OcpiModule.Credentials, "Receiver", "2.2, 2.2.1")]
[Route("2.2/credentials")]
[Route("2.2.1/credentials")]
public class CredentialsController : OcpiController
{
    [HttpGet]
    public IActionResult Get()
    {
        // Retreive requesting platform's credentials

        return OcpiOk(SampleCredentials);
    }

    [HttpPost]
    public IActionResult Post([FromBody] OcpiCredentials credentials)
    {
        // if (platform.IsRegistered == true) throw ApiException.MethodNotAllowed("The platform is already registered.");

        // Register requesting platform

        return OcpiOk(SampleCredentials);
    }

    [HttpPut]
    public IActionResult Put([FromBody] OcpiCredentials credentials)
    {
        // if (platform.IsRegistered == false) throw ApiException.MethodNotAllowed("The platform has to be registered in order to perform this action.");

        // Update requesting platform's credentials

        return OcpiOk(SampleCredentials);
    }

    [HttpDelete]
    public IActionResult Delete()
    {
        // if (platform.IsRegistered == false) throw ApiException.MethodNotAllowed("The platform has to be registered in order to perform this action.");

        // Unregister the requesting platform

        return OcpiOk("Success");
    }

    private static OcpiCredentials SampleCredentials => new()
    {
        Token = "Requesting-Platform's-Credentials-Token",
        Url = "Your-Service's-Versions-Endpoint-Url",
        Roles = new List<OcpiCredentialsRole>
            {
                new()
                {
                    CountryCode = CountryCode.TestCountry,
                    PartyId = "XXX",
                    Role = PartyRole.Cpo,
                    BusinessDetails = new OcpiBusinessDetails
                    {
                        Name = "Your-Business-Details"
                    }
                }
            }
    };
}