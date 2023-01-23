using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class VersionViewModel
{
    [JsonPropertyName("version")]
    public required OcpiVersion Version { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}
