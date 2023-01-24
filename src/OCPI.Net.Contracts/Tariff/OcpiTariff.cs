using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiTariff
{
    [JsonPropertyName("country_code")]
    public CountryCode? CountryCode { get; set; }

    [JsonPropertyName("party_id")]
    public string? PartyId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("type")]
    public TariffType? Type { get; set; }

    [JsonPropertyName("tariff_alt_text")]
    public IEnumerable<OcpiDisplayText>? TariffAltText { get; set; }

    [JsonPropertyName("tariff_alt_url")]
    public string? Url { get; set; }

    [JsonPropertyName("min_price")]
    public OcpiPrice? MinPrice { get; set; }

    [JsonPropertyName("max_price")]
    public OcpiPrice? MaxPrice { get; set; }

    [JsonPropertyName("elements")]
    public IEnumerable<OcpiTariffElement>? Elements { get; set; }

    [JsonPropertyName("start_date_time")]
    public DateTime? Start { get; set; }

    [JsonPropertyName("end_date_time")]
    public DateTime? End { get; set; }

    [JsonPropertyName("energy_mix")]
    public OcpiEnergyMix? EnergyMix { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTime? LastUpdated { get; set; }
}
