using BitzArt.Pagination;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace OCPI;

public class OcpiPageRequest : PageRequest
{
    [JsonPropertyName("date_from")]
    [FromQuery(Name = "date_from")]
    public DateTime? From { get; set; }

    [JsonPropertyName("date_to")]
    [FromQuery(Name = "date_to")]
    public DateTime? To { get; set; }
}
