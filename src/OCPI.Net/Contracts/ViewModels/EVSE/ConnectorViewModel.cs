using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class ConnectorViewModel
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("evseId")]
    public Guid? EvseId { get; set; }

    [JsonPropertyName("standard")]
    public ConnectorType? Standard { get; set; }

    [JsonPropertyName("format")]
    public ConnectorFormat? Format { get; set; }

    [JsonPropertyName("power_type")]
    public PowerType? PowerType { get; set; }

    [JsonPropertyName("max_voltage")]
    public int? MaxVoltage { get; set; }

    [JsonPropertyName("max_amperage")]
    public int? MaxAmperage { get; set; }

    [JsonPropertyName("max_electric_power")]
    public int? MaxElectricPower { get; set; }

    [JsonPropertyName("tariff_ids")]
    public IEnumerable<string>? TariffIds { get; set; }

    [JsonPropertyName("terms_and_conditions")]
    public string? TermsAndConditionsUrl { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTime? LastUpdated { get; set; }
}
