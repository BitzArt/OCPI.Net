using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class VersionDetailsViewModel
{
    [JsonPropertyName("version")]
    public required OcpiVersion Version { get; set; }

    [JsonPropertyName("endpoints")]
    public required IEnumerable<EndpointViewModel> Endpoints { get; set; }
}
