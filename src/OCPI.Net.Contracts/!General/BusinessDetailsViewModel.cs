using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class BusinessDetailsViewModel
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("website")]
    public string? Website { get; set; }

    [JsonPropertyName("logo")]
    public ImageViewModel? Logo { get; set; }
}
