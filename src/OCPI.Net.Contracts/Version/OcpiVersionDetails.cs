using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiVersionDetails
{
    [JsonPropertyName("version")]
    public required OcpiVersion Version { get; set; }

    [JsonPropertyName("endpoints")]
    public required IEnumerable<OcpiEndpoint> Endpoints { get; set; }
}
