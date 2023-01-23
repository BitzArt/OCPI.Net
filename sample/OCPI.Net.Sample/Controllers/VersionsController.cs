using BitzArt.EnumToMemberValue;
using Microsoft.AspNetCore.Mvc;
using OCPI.Contracts;

namespace OCPI.Sample.Controllers;

[Route("versions")]
public class VersionsController : OcpiController
{
    private readonly IOcpiVersionService _versions;
    private readonly OcpiOptions _options;

    public VersionsController(IOcpiVersionService versions, OcpiOptions options)
    {
        _versions = versions;
        _options = options;
    }

    [HttpGet]
    public IActionResult GetAsync()
    {
        var versions = _versions.GetVersions();
        var result = versions.Select(x => new VersionViewModel
        {
            Version = x,
            Url = $"{_options.BaseServiceUrl}/versions/{x.ToMemberValue()}"
        });
        return Ok(result);
    }

    [HttpGet("{request}")]
    public IActionResult GetAsync([FromRoute]string request)
    {
        var version = request.ToEnum<OcpiVersion>(OcpiVersion.Invalid);
        if (version == OcpiVersion.Invalid) throw OcpiException.ClientError($"Invalid OCPI Version: '{request}'");

        var routes = _versions.GetRoutes(version);
        var result = new VersionDetailsViewModel()
        {
            Version = version,
            Endpoints = routes.Select(x => new EndpointViewModel
            {
                Identifier = x.OcpiModule,
                Role = x.InterfaceRole,
                Url = $"{_options.BaseServiceUrl}/{x.Route}"
            })
        };
        return Ok(result);
    }
}