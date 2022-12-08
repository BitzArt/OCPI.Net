using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class CdrTokenViewModel
{
    [JsonPropertyName("country_code")]
    public string? CountryCode { get; set; }

    [JsonPropertyName("party_id")]
    public string? PartyId { get; set; }

    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    [JsonPropertyName("type")]
    public TokenType? Type { get; set; }

    [JsonPropertyName("contract_id")]
    public string? ContractId { get; set; }
}
