using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiTariffElement
{
    [JsonPropertyName("price_components")]
    public IEnumerable<OcpiPriceComponent>? PriceComponents { get; set; }

    [JsonPropertyName("restrictions")]
    public OcpiTariffRestrictions? Restrictions { get; set; }
}
