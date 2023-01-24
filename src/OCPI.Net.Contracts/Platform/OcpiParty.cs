using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiParty
{
    [JsonPropertyName("country_code")]
    public CountryCode? CountryCode { get; set; }

    [JsonPropertyName("party_id")]
    public string? PartyId { get; set; }

    [JsonPropertyName("role")]
    public PartyRole? Role { get; set; }

    [JsonPropertyName("business_details")]
    public OcpiBusinessDetails? BusinessDetails { get; set; }
}
