using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class ExceptionalPeriodViewModel
{
    [JsonPropertyName("period_begin")]
    public DateTime? PeriodBegin { get; set; }

    [JsonPropertyName("period_end")]
    public DateTime? PeriodEnd { get; set; }
}
