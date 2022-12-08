using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class ChargingPeriodViewModel
{
    [JsonPropertyName("start_date_time")]
    public DateTime? Start { get; set; }

    [JsonPropertyName("dimensions")]
    public IEnumerable<CdrDimensionViewModel>? Dimensions { get; set; }

    [JsonPropertyName("tariff_id")]
    public string? TariffId { get; set; }
}
