using Microsoft.AspNetCore.Mvc;
using OCPI.Contracts;

namespace OCPI.Sample.Controllers;

[OcpiEndpoint(OcpiModule.Locations, "Receiver", "2.2, 2.2.1")]
[Route("2.2/locations")]
[Route("2.2.1/locations")]
[OcpiAuthorize]
public class OcpiLocationsReceiverController : OcpiController
{
    [HttpGet("{countryCode}/{partyId}/{locationId}")]
    public IActionResult Get(
        [FromRoute] string countryCode,
        [FromRoute] string partyId,
        [FromRoute] string locationId)
    {
        return OcpiOk(SampleLocation);
    }

    [HttpPut("{countryCode}/{partyId}/{locationId}")]
    public IActionResult Put(
        [FromRoute] string countryCode,
        [FromRoute] string partyId,
        [FromRoute] string locationId,
        [FromBody] OcpiLocation location)
    {
        // Use a built-in OCPI validator
        OcpiValidate(location);

        // Your Location PUT logic

        return OcpiOk(location);
    }

    [HttpPatch("{countryCode}/{partyId}/{locationId}")]
    public IActionResult Patch(
        [FromRoute] string countryCode,
        [FromRoute] string partyId,
        [FromRoute] string locationId,
        [FromBody] OcpiLocation location)
    {
        // Use a built-in OCPI validator
        // Validator behavior will be appropriate to PATCH
        // Since this is a PATCH method
        // (not throw errors on missing fields)
        OcpiValidate(location);

        // Your Location PATCH logic

        return OcpiOk(location);
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