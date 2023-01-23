using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class AdditionalGeolocationViewModel
{
    [JsonPropertyName("latitude")]
    public string? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public string? Longitude { get; set; }

    [JsonPropertyName("name")]
    public DisplayTextViewModel? Name { get; set; }
}
