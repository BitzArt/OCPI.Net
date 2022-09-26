using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class EnergyMixViewModel
{
    [JsonPropertyName("is_green_energy")]
    public bool? IsGreenEnergy { get; set; }

    [JsonPropertyName("energy_sources")]
    public IEnumerable<EnergySourceViewModel>? EnergySources { get; set; }

    [JsonPropertyName("environ_impact")]
    public IEnumerable<EnvironmentalImpactViewModel>? EnvironmentalImpact { get; set; }

    [JsonPropertyName("supplier_name")]
    public string? SupplierName { get; set; }

    [JsonPropertyName("energy_product_name")]
    public string? EnergyProductName { get; set; }
}
