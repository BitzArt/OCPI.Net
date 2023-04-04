using BitzArt.Pagination;
using System.Text.Json.Serialization;

namespace OCPI;

public class OcpiPageRequest : PageRequest
{
    [JsonPropertyName("date_from")]
    public DateTime? From { get; set; }
    [JsonPropertyName("date_to")]
    public DateTime? To { get; set; }
}
