using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiChargingPeriod
{
    [JsonPropertyName("start_date_time")]
    public DateTime? Start { get; set; }

    [JsonPropertyName("dimensions")]
    public IEnumerable<OcpiCdrDimension>? Dimensions { get; set; }

    [JsonPropertyName("tariff_id")]
    public string? TariffId { get; set; }
}
