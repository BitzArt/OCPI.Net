using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class EnergySourceViewModel
{
    [JsonPropertyName("source")]
    public EnergySourceCategory? Source { get; set; }

    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}
