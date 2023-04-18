using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiUnlockConnectorCommand
{
    /// <summary>
    /// URL that the
    /// <see cref="OcpiCommandResult">CommandResult</see>
    /// POST should be sent to.
    /// This URL might contain a unique ID to be able to distinguish
    /// between
    /// <see cref="OcpiUnlockConnectorCommand">UnlockConnector</see>
    /// requests.
    /// </summary>
    [JsonPropertyName("response_url")]
    public string? ResponseUrl { get; set; }

    /// <summary>
    /// <see cref="OcpiLocation.Id">Id</see>
    /// of the
    /// <see cref="OcpiLocation">Location</see>
    /// (belonging to the CPO this request is sent to)
    /// for which to reserve an
    /// <see cref="OcpiEvse">EVSE</see>.
    /// </summary>
    [JsonPropertyName("location_id")]
    public string? LocationId { get; set; }

    /// <summary>
    /// Optional
    /// <see cref="OcpiEvse.Uid">uid</see>
    /// of the
    /// <see cref="OcpiEvse">EVSE</see>
    /// of this
    /// <see cref="OcpiLocation">Location</see>
    /// if a specific EVSE has to be reserved.
    /// </summary>
    [JsonPropertyName("evse_uid")]
    public string? EvseUid { get; set; }

    /// <summary>
    /// Optional
    /// <see cref="OcpiConnector.Id">Id</see>
    /// of the
    /// <see cref="OcpiConnector">Connector</see>
    /// of the
    /// <see cref="OcpiEvse">EVSE</see>
    /// on which a
    /// <see cref="OcpiSession">Session</see>
    /// is to be started.
    /// This field is required when the
    /// <see cref="EvseCapabilityType.StartSessionConnectorRequired"/>
    /// is set on the
    /// <see cref="OcpiEvse">EVSE</see>.
    /// </summary>
    [JsonPropertyName("connector_id")]
    public string? ConnectorId { get; set; }
}
