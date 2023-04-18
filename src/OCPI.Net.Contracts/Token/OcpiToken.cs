using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiToken
{
    [JsonPropertyName("country_code")]
    public CountryCode? CountryCode { get; set; }

    [JsonPropertyName("party_id")]
    public string? PartyId { get; set; }

    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    [JsonPropertyName("type")]
    public TokenType? Type { get; set; }

    [JsonPropertyName("contract_id")]
    public string? ContractId { get; set; }

    [JsonPropertyName("visual_number")]
    public string? VisualNumber { get; set; }

    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    [JsonPropertyName("group_id")]
    public string? GroupId { get; set; }

    [JsonPropertyName("valid")]
    public bool? Valid { get; set; }

    [JsonPropertyName("whitelist")]
    public WhitelistType? Whitelist { get; set; }

    [JsonPropertyName("language")]
    public string? LanguageCode { get; set; }

    [JsonPropertyName("default_profile_type")]
    public ProfileType? DefaultProfileType { get; set; }

    [JsonPropertyName("energy_contract")]
    public OcpiEnergyContract? EnergyContract { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTime? LastUpdated { get; set; }
}
