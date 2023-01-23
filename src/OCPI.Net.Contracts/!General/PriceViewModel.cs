using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class PriceViewModel
{
    [JsonPropertyName("excl_vat")]
    public decimal? VatExcluded { get; set; }

    [JsonPropertyName("incl_vat")]
    public decimal? VatIncluded { get; set; }
}
