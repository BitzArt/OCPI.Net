using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class SessionViewModel
{
    [JsonPropertyName("country_code")]
    public CountryCode? CountryCode { get; set; }

    [JsonPropertyName("party_id")]
    public string? PartyId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("start_date_time")]
    public DateTime? Start { get; set; }

    [JsonPropertyName("end_date_time")]
    public DateTime? End { get; set; }

    [JsonPropertyName("kwh")]
    public decimal? Kwh { get; set; }

    [JsonPropertyName("auth_method")]
    public AuthMethodType? AuthMethod { get; set; }

    [JsonPropertyName("authorization_reference")]
    public string? AuthorizationReference { get; set; }

    [JsonPropertyName("meter_id")]
    public string? MeterId { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("status")]
    public SessionStatus? Status { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTime? LastUpdated { get; set; }

    [JsonPropertyName("location_id")]
    public string? LocationId { get; set; }

    [JsonPropertyName("evse_uid")]
    public string? EvseId { get; set; }

    [JsonPropertyName("connector_id")]
    public string? ConnectorId { get; set; }

    [JsonPropertyName("cdr_token")]
    public CdrTokenViewModel? CdrToken { get; set; }

    [JsonPropertyName("total_cost")]
    public PriceViewModel? TotalCost { get; set; }

    [JsonPropertyName("charging_periods")]
    public IEnumerable<ChargingPeriodViewModel>? ChargingPeriods { get; set; }
}
