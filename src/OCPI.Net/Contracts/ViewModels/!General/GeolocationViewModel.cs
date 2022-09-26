using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class GeolocationViewModel
{
    [JsonPropertyName("latitude")]
    public string? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public string? Longitude { get; set; }
}
