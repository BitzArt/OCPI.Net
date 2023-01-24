using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiCredentials
{
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("roles")]
    public IEnumerable<OcpiCredentialsRole>? Roles { get; set; }
}
