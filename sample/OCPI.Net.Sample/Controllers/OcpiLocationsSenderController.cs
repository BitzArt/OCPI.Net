using Microsoft.AspNetCore.Mvc;
using OCPI.Contracts;

namespace OCPI.Sample.Controllers;

[OcpiEndpoint(OcpiModule.Locations, "Sender", "2.2, 2.2.1")]
[Route("2.2/locations")]
[Route("2.2.1/locations")]
[OcpiAuthorize]
public class OcpiLocationsSenderController : OcpiController
{
    [HttpGet]
    public IActionResult GetPage([FromQuery] OcpiPageRequest pageRequest)
    {
        // Set maximum Limit value
        // Required for OCPI.Net PageResult handling
        SetMaxLimit(pageRequest, 100);

        // Process GetPage using Offset, Limit, DateFrom, DateTo from pageRequest

        // You can use BitzArt.Pagination nuget package
        // https://github.com/BitzArt/Pagination
        // to handle Offset and Limit (does not handle DateFrom/DateTo),
        // or implement your own OcpiPageRequest handling logic.

        // Example:
        var databaseLocations = Enumerable.Range(1, 100).Select(x =>
        {
            var location = SampleLocation;
            location.Id = $"SampleLocation-{x}";
            return location;
        });

        // This will handle Offset and Limit but not DateFrom or DateTo:
        var result = databaseLocations.ToPage(pageRequest);

        // Returning a PageResult in OcpiOk will process the paginated response
        // and add appropriate page response headers.
        return OcpiOk(result);
    }

    private static OcpiLocation SampleLocation => new()
    {
        CountryCode = CountryCode.Belgium,
        PartyId = "BEC",
        Id = "LOC1",
        Publish = true,
        Name = "Gent Zuid",
        Address = "F.Rooseveltlaan 3A",
        City = "Gent",
        PostalCode = "9000",
        Country = "BEL",
        Coordinates = new OcpiGeolocation
        {
            Latitude = "51.047599",
            Longitude = "3.729944"
        },
        ParkingType = ParkingType.OnStreet,
        TimeZone = "Europe/Brussels",
        LastUpdated = DateTime.UtcNow
    };
}