using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiSignedValue
{
    [JsonPropertyName("nature")]
    public string? Nature { get; set; }

    [JsonPropertyName("plain_data")]
    public string? PlainData { get; set; }

    [JsonPropertyName("signed_data")]
    public string? SignedData { get; set; }
}
