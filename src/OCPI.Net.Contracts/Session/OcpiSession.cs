﻿using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiSession
{
    [JsonPropertyName("country_code")]
    public CountryCode? CountryCode { get; set; }

    [JsonPropertyName("party_id")]
    public string? PartyId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("start_date_time")]
    public DateTime? StartDateTime { get; set; }

    [JsonPropertyName("end_date_time")]
    public DateTime? EndDateTime { get; set; }

    [JsonPropertyName("kwh")]
    public decimal? Kwh { get; set; }

    [JsonPropertyName("cdr_token")]
    public OcpiCdrToken? CdrToken { get; set; }

    [JsonPropertyName("auth_method")]
    public AuthMethodType? AuthMethod { get; set; }

    [JsonPropertyName("authorization_reference")]
    public string? AuthorizationReference { get; set; }

    [JsonPropertyName("location_id")]
    public string? LocationId { get; set; }

    [JsonPropertyName("evse_uid")]
    public string? EvseId { get; set; }

    [JsonPropertyName("connector_id")]
    public string? ConnectorId { get; set; }

    [JsonPropertyName("meter_id")]
    public string? MeterId { get; set; }

    [JsonPropertyName("currency")]
    public CurrencyCode? Currency { get; set; }

    [JsonPropertyName("charging_periods")]
    public IEnumerable<OcpiChargingPeriod>? ChargingPeriods { get; set; }

    [JsonPropertyName("total_cost")]
    public OcpiPrice? TotalCost { get; set; }

    [JsonPropertyName("status")]
    public SessionStatus? Status { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTime? LastUpdated { get; set; }
}
