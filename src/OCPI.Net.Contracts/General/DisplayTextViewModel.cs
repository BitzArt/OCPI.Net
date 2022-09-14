using System.Text.Json.Serialization;

namespace OCPI.Contracts
{
    public class DisplayTextViewModel
    {
        [JsonPropertyName("language")]
        public string? LanguageCode { get; set; }

        [JsonPropertyName("text")]
        public string? Text { get; set; }
    }
}
