using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class EndpointViewModel
{
    [JsonPropertyName("identifier")]
    public required OcpiModule Identifier { get; set; }

    [JsonPropertyName("role")]
    public required InterfaceRole Role { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}
