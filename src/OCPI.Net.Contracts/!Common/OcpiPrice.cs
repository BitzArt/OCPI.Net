using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiPrice
{
    [JsonPropertyName("excl_vat")]
    public decimal? ExclVat { get; set; }

    [JsonPropertyName("incl_vat")]
    public decimal? InclVat { get; set; }
}
