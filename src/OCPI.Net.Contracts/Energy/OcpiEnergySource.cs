using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiEnergySource
{
    [JsonPropertyName("source")]
    public EnergySourceCategory? Source { get; set; }

    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}
