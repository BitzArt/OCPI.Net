using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiHours
{
    [JsonPropertyName("twentyfourseven")]
    public bool? TwentyFourSeven { get; set; }

    [JsonPropertyName("regular_hours")]
    public IEnumerable<OcpiRegularHours>? RegularHours { get; set; }

    [JsonPropertyName("exceptional_openings")]
    public IEnumerable<OcpiExceptionalPeriod>? ExceptionalOpenings { get; set; }

    [JsonPropertyName("exceptional_closings")]
    public IEnumerable<OcpiExceptionalPeriod>? ExceptionalClosings { get; set; }
}
