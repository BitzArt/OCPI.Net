using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiCdr
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

    [JsonPropertyName("session_id")]
    public string? SessionId { get; set; }

    [JsonPropertyName("cdr_token")]
    public OcpiCdrToken? CdrToken { get; set; }

    [JsonPropertyName("auth_method")]
    public AuthMethodType? AuthMethod { get; set; }

    [JsonPropertyName("authorization_reference")]
    public string? AuthorizationReference { get; set; }

    [JsonPropertyName("cdr_location")]
    public OcpiCdrLocation? CdrLocation { get; set; }

    [JsonPropertyName("meter_id")]
    public string? MeterId { get; set; }

    [JsonPropertyName("currency")]
    public CurrencyCode? Currency { get; set; }

    [JsonPropertyName("tariffs")]
    public IEnumerable<OcpiTariff>? Tariffs { get; set; }

    [JsonPropertyName("charging_periods")]
    public IEnumerable<OcpiChargingPeriod>? ChargingPeriods { get; set; }

    [JsonPropertyName("signed_data")]
    public OcpiSignedData? SignedData { get; set; }

    [JsonPropertyName("total_cost")]
    public OcpiPrice? TotalCost { get; set; }

    [JsonPropertyName("total__fixed_cost")]
    public OcpiPrice? TotalFixedCost { get; set; }

    [JsonPropertyName("total_energy")]
    public decimal? TotalEnergy { get; set; }

    [JsonPropertyName("total_energy_cost")]
    public OcpiPrice? TotalEnergyCost { get; set; }

    [JsonPropertyName("total_time")]
    public decimal? TotalTime { get; set; }

    [JsonPropertyName("total_time_cost")]
    public OcpiPrice? TotalTimeCost { get; set; }

    [JsonPropertyName("total_parking_time")]
    public decimal? TotalParkingTime { get; set; }

    [JsonPropertyName("total_parking_cost")]
    public OcpiPrice? TotalParkingCost { get; set; }

    [JsonPropertyName("total_reservation_cost")]
    public OcpiPrice? TotalReservationCost { get; set; }

    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    [JsonPropertyName("invoice_reference_id")]
    public string? InvoiceReferenceId { get; set; }

    [JsonPropertyName("credit")]
    public bool? Credit { get; set; }

    [JsonPropertyName("credit_reference_id")]
    public string? CreditReferenceId { get; set; }

    [JsonPropertyName("home_charging_compensation")]
    public bool? HomeChargingCompensation { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTime? LastUpdated { get; set; }
}
