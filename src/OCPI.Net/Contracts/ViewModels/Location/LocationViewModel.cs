using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class LocationViewModel
{
    [JsonPropertyName("country_code")]
    public CountryCode? CountryCode { get; set; }

    [JsonPropertyName("party_id")]
    public string? PartyId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("publish")]
    public bool? Publish { get; set; }

    [JsonPropertyName("publish_allowed_to")]
    public IEnumerable<PublishTokenTypeViewModel>? PublishAllowedTo { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("postal_code")]
    public string? PostalCode { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("coordinates")]
    public GeolocationViewModel? Coordinates { get; set; }

    [JsonPropertyName("related_locations")]
    public IEnumerable<AdditionalGeolocationViewModel>? RelatedLocations { get; set; }

    [JsonPropertyName("parking_type")]
    public ParkingType? ParkingType { get; set; }

    [JsonPropertyName("evses")]
    public IEnumerable<EvseViewModel>? Evses { get; set; }

    [JsonPropertyName("directions")]
    public IEnumerable<DisplayTextViewModel>? Directions { get; set; }

    [JsonPropertyName("operator")]
    public BusinessDetailsViewModel? Operator { get; set; }

    [JsonPropertyName("suboperator")]
    public BusinessDetailsViewModel? Suboperator { get; set; }

    [JsonPropertyName("owner")]
    public BusinessDetailsViewModel? Owner { get; set; }

    [JsonPropertyName("facilities")]
    public IEnumerable<FacilityType>? Facilities { get; set; }

    [JsonPropertyName("time_zone")]
    public string? TimeZone { get; set; }

    [JsonPropertyName("opening_times")]
    public WorkingHoursViewModel? OpeningTimes { get; set; }

    [JsonPropertyName("charging_when_closed")]
    public bool? ChargingWhenClosed { get; set; }

    [JsonPropertyName("images")]
    public IEnumerable<ImageViewModel>? Images { get; set; }

    [JsonPropertyName("energy_mix")]
    public EnergyMixViewModel? EnergyMix { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTime? LastUpdated { get; set; }
}
