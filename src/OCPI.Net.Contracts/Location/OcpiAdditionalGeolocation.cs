using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiAdditionalGeolocation
{
    [JsonPropertyName("latitude")]
    public string? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public string? Longitude { get; set; }

    [JsonPropertyName("name")]
    public OcpiDisplayText? Name { get; set; }
}
