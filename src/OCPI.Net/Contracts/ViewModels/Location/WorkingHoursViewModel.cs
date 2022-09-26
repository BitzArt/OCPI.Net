using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class WorkingHoursViewModel
{
    [JsonPropertyName("twentyfourseven")]
    public bool? TwentyFourSeven { get; set; }

    [JsonPropertyName("regular_hours")]
    public IEnumerable<RegularHoursViewModel>? RegularHours { get; set; }

    [JsonPropertyName("exceptional_openings")]
    public IEnumerable<ExceptionalPeriodViewModel>? ExceptionalOpenings { get; set; }

    [JsonPropertyName("exceptional_closings")]
    public IEnumerable<ExceptionalPeriodViewModel>? ExceptionalClosings { get; set; }
}
