using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class EnvironmentalImpactViewModel
{
    [JsonPropertyName("category")]
    public EnvironmentalImpactCategory? Category { get; set; }

    [JsonPropertyName("amount")]
    public double? Amount { get; set; }
}
