using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiPublishTokenType
{
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    [JsonPropertyName("type")]
    public TokenType? Type { get; set; }

    [JsonPropertyName("visual_number")]
    public string? VisualNumber { get; set; }

    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    [JsonPropertyName("group_id")]
    public string? GroupId { get; set; }
}
