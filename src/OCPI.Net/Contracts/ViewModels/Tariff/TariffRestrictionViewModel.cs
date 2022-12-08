using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class TariffRestrictionViewModel
{
    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }

    [JsonPropertyName("end_time")]
    public string? EndTime { get; set; }

    [JsonPropertyName("start_date")]
    public string? StartDate { get; set; }

    [JsonPropertyName("end_date")]
    public string? EndDate { get; set; }

    [JsonPropertyName("min_kwh")]
    public decimal? MinKwh { get; set; }

    [JsonPropertyName("max_kwh")]
    public decimal? MaxKwh { get; set; }

    [JsonPropertyName("min_current")]
    public decimal? MinCurrent { get; set; }

    [JsonPropertyName("max_current")]
    public decimal? MaxCurrent { get; set; }

    [JsonPropertyName("min_power")]
    public decimal? MinPower { get; set; }

    [JsonPropertyName("max_power")]
    public decimal? MaxPower { get; set; }

    [JsonPropertyName("min_duration")]
    public int? MinDuration { get; set; }

    [JsonPropertyName("max_duration")]
    public int? MaxDuration { get; set; }

    [JsonPropertyName("day_of_week")]
    public IEnumerable<OcpiDayOfWeek>? DayOfWeek { get; set; }

    [JsonPropertyName("reservation")]
    public ReservationRestrictionType? Reservation { get; set; }
}
