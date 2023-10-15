using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiCdrLocation
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("postal_code")]
    public string? PostalCode { get; set; }

    [OcpiIntroduced("2.2.1")]
    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("coordinates")]
    public OcpiGeolocation? Coordinates { get; set; }

    [JsonPropertyName("evse_uid")]
    public string? EvseUid { get; set; }

    [JsonPropertyName("evse_id")]
    public string? EvseId { get; set; }

    [JsonPropertyName("connector_id")]
    public string? ConnectorId { get; set; }

    [JsonPropertyName("connector_standard")]
    public ConnectorType? ConnectorStandard { get; set; }

    [JsonPropertyName("connector_format")]
    public ConnectorFormat? ConnectorFormat { get; set; }

    [JsonPropertyName("connector_power_type")]
    public PowerType? ConnectorPowerType { get; set; }
}
