using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiStopSessionCommand
{
    /// <summary>
    /// URL that the
    /// <see cref="OcpiCommandResult">CommandResult</see>
    /// POST should be sent to.
    /// This URL might contain a unique ID to be able to distinguish
    /// between
    /// <see cref="OcpiStopSessionCommand">StopSession</see>
    /// requests.
    /// </summary>
    [JsonPropertyName("response_url")]
    public string? ResponseUrl { get; set; }

    /// <summary>
    /// <see cref="OcpiSession.Id">Id</see>
    /// of the
    /// <see cref="OcpiSession">Session</see>
    /// that is requested to be stopped.
    /// </summary>
    [JsonPropertyName("session_id")]
    public string? SessionId { get; set; }
}
