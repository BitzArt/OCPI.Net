using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiGeolocation
{
    [JsonPropertyName("latitude")]
    public string? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public string? Longitude { get; set; }
}
