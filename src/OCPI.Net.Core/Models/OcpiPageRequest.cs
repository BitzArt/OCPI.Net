using BitzArt.Pagination;
using System.Text.Json.Serialization;

namespace OCPI
{
    public class OcpiPageRequest : PageRequest
    {
        [JsonPropertyName("from")]
        public DateTime? From { get; set; }
        [JsonPropertyName("to")]
        public DateTime? To { get; set; }
    }
}
