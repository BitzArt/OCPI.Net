using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class CdrDimensionViewModel
{
    [JsonPropertyName("type")]
    public CdrDimensionType? Type { get; set; }

    [JsonPropertyName("volume")]
    public decimal? Volume { get; set; }
}
