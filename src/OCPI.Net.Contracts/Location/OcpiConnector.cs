using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiConnector
{
    //==================== OCPI 2.2.1 ========================

    [JsonPropertyName("id")]
    public string? Id { get; set; }

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

    //==================== Deprecated in OCPI 2.2 ========================

    [OcpiDeprecated(after: "2.1.1")]
    [JsonPropertyName("voltage")]
    public int? Voltage { get; set; }

    [OcpiDeprecated(after: "2.1.1")]
    [JsonPropertyName("amperage")]
    public int? Amperage { get; set; }

    [OcpiDeprecated(after: "2.1.1")]
    [JsonPropertyName("tariff_id")]
    public string? TariffId { get; set; }
}
