using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiConnector
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("standard")]
    public ConnectorType? Standard { get; set; }

    [JsonPropertyName("format")]
    public ConnectorFormat? Format { get; set; }

    [JsonPropertyName("power_type")]
    public PowerType? PowerType { get; set; }

    //OCPI 2.1.1 property
    [JsonPropertyName("voltage")]
    public int? Voltage { get; set; }

    [JsonPropertyName("max_voltage")]
    public int? MaxVoltage { get; set; }

    //OCPI 2.1.1 property
    [JsonPropertyName("amperage")]
    public int? Amperage { get; set; }

    [JsonPropertyName("max_amperage")]
    public int? MaxAmperage { get; set; }

    [JsonPropertyName("max_electric_power")]
    public int? MaxElectricPower { get; set; }

    //OCPI 2.1.1 property
    [JsonPropertyName("tariff_id")]
    public string? TariffId { get; set; }

    [JsonPropertyName("tariff_ids")]
    public IEnumerable<string>? TariffIds { get; set; }

    [JsonPropertyName("terms_and_conditions")]
    public string? TermsAndConditionsUrl { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTime? LastUpdated { get; set; }
}
