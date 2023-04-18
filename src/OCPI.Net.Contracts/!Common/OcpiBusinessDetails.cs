using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiBusinessDetails
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("website")]
    public string? Website { get; set; }

    [JsonPropertyName("logo")]
    public OcpiImage? Logo { get; set; }
}
