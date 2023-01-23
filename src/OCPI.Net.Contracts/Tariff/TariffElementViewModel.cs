using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class TariffElementViewModel
{
    [JsonPropertyName("price_components")]
    public IEnumerable<PriceComponentViewModel>? PriceComponents { get; set; }

    [JsonPropertyName("restrictions")]
    public IEnumerable<TariffRestrictionViewModel>? Restrictions { get; set; }
}
