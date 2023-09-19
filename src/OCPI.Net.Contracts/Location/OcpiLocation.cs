using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiLocation
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
    public IEnumerable<OcpiPublishTokenType>? PublishAllowedTo { get; set; }

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
    public OcpiGeolocation? Coordinates { get; set; }

    [JsonPropertyName("related_locations")]
    public IEnumerable<OcpiAdditionalGeolocation>? RelatedLocations { get; set; }

    //OCPI 2.1.1 property
    [JsonPropertyName("type")]
    public LocationType? Type { get; set; }

    [JsonPropertyName("parking_type")]
    public ParkingType? ParkingType { get; set; }

    [JsonPropertyName("evses")]
    public IEnumerable<OcpiEvse>? Evses { get; set; }

    [JsonPropertyName("directions")]
    public IEnumerable<OcpiDisplayText>? Directions { get; set; }

    [JsonPropertyName("operator")]
    public OcpiBusinessDetails? Operator { get; set; }

    [JsonPropertyName("suboperator")]
    public OcpiBusinessDetails? Suboperator { get; set; }

    [JsonPropertyName("owner")]
    public OcpiBusinessDetails? Owner { get; set; }

    [JsonPropertyName("facilities")]
    public IEnumerable<FacilityType>? Facilities { get; set; }

    [JsonPropertyName("time_zone")]
    public string? TimeZone { get; set; }

    [JsonPropertyName("opening_times")]
    public OcpiHours? OpeningTimes { get; set; }

    [JsonPropertyName("charging_when_closed")]
    public bool? ChargingWhenClosed { get; set; }

    [JsonPropertyName("images")]
    public IEnumerable<OcpiImage>? Images { get; set; }

    [JsonPropertyName("energy_mix")]
    public OcpiEnergyMix? EnergyMix { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTime? LastUpdated { get; set; }
}
