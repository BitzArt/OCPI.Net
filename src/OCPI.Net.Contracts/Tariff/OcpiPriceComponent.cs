using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiPriceComponent
{
    [JsonPropertyName("type")]
    public TariffDimensionType? Type { get; set; }

    [JsonPropertyName("price")]
    public decimal? Price { get; set; }

    [JsonPropertyName("vat")]
    public decimal? Vat { get; set; }

    [JsonPropertyName("step_size")]
    public int? StepSize { get; set; }
}
