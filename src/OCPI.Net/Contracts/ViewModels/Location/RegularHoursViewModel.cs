using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class RegularHoursViewModel
{
    [JsonPropertyName("weekday")]
    public byte? Weekday { get; set; }

    [JsonPropertyName("period_begin")]
    public string? PeriodBegin { get; set; }

    [JsonPropertyName("period_end")]
    public string? PeriodEnd { get; set; }
}
