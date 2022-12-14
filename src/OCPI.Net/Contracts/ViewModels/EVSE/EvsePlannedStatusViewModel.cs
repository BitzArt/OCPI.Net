using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class EvsePlannedStatusViewModel
{
    [JsonPropertyName("period_begin")]
    public DateTime? PeriodBegin { get; set; }

    [JsonPropertyName("period_end")]
    public DateTime? PeriodEnd { get; set; }

    [JsonPropertyName("status")]
    public EvseStatus? Status { get; set; }
}
