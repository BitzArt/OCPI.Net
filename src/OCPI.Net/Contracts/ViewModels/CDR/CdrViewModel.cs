using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class CdrViewModel
{
    [JsonPropertyName("country_code")]
    public string? CountryCode { get; set; }

    [JsonPropertyName("party_id")]
    public string? PartyId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("start_date_time")]
    public DateTime? Start { get; set; }

    [JsonPropertyName("end_date_time")]
    public DateTime? End { get; set; }

    [JsonPropertyName("session_id")]
    public string? SessionId { get; set; }

    [JsonPropertyName("auth_method")]
    public AuthMethodType? AuthMethod { get; set; }

    [JsonPropertyName("authorization_reference")]
    public string? AuthorizationReference { get; set; }

    [JsonPropertyName("meter_id")]
    public string? MeterId { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("total_energy")]
    public decimal? TotalEnergy { get; set; }

    [JsonPropertyName("total_time")]
    public decimal? TotalTime { get; set; }

    [JsonPropertyName("total_parking_time")]
    public decimal? TotalParkingTime { get; set; }

    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    [JsonPropertyName("invoice_reference_id")]
    public string? InvoiceReferenceId { get; set; }

    [JsonPropertyName("credit")]
    public bool? Credit { get; set; }

    [JsonPropertyName("credit_reference_id")]
    public string? CreditReferenceId { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTime? ExternalUpdated { get; set; }

    [JsonPropertyName("cdr_token")]
    public CdrTokenViewModel? CdrToken { get; set; }

    [JsonPropertyName("cdr_location")]
    public CdrLocationViewModel? CdrLocation { get; set; }

    [JsonPropertyName("signed_data")]
    public SignedDataViewModel? SignedData { get; set; }

    [JsonPropertyName("total_cost")]
    public PriceViewModel? TotalCost { get; set; }

    [JsonPropertyName("total__fixed_cost")]
    public PriceViewModel? TotalFixedCost { get; set; }

    [JsonPropertyName("total_energy_cost")]
    public PriceViewModel? TotalEnergyCost { get; set; }

    [JsonPropertyName("total_time_cost")]
    public PriceViewModel? TotalTimeCost { get; set; }

    [JsonPropertyName("total_parking_cost")]
    public PriceViewModel? TotalParkingCost { get; set; }

    [JsonPropertyName("total_reservation_cost")]
    public PriceViewModel? TotalReservationCost { get; set; }

    [JsonPropertyName("home_charging_compensation")]
    public bool? HomeChargingCompensation { get; set; }

    [JsonPropertyName("tariffs")]
    public IEnumerable<TariffViewModel>? Tariffs { get; set; }

    [JsonPropertyName("charging_periods")]
    public IEnumerable<ChargingPeriodViewModel>? ChargingPeriods { get; set; }
}
