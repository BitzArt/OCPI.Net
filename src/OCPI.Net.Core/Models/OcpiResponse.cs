using BitzArt.EnumToMemberValue;
using System.Text.Json.Serialization;

namespace OCPI;

public class OcpiResponse<TData> : OcpiResponse
{
    [JsonPropertyName("data")]
    public new TData? Data
    {
        get => (TData)base.Data!;
        set => base.Data = value;
    }

    public OcpiResponse() { }

    public OcpiResponse(TData data, OcpiStatusCode statusCode = OcpiStatusCode.Success)
        : this(data, (int)statusCode) { }

    public OcpiResponse(TData data, int statusCode) : base(data!, statusCode) { }
}

public class OcpiResponse
{
    [JsonPropertyName("data")]
    public object? Data { get; set; }

    [JsonPropertyName("status_code")]
    public int? StatusCode { get; set; }

    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime? Timestamp { get; set; }

    [JsonPropertyName("problem")]
    public object? Problem { get; set; }

    public OcpiResponse()
    {
        Timestamp = DateTime.UtcNow;
    }

    public OcpiResponse(object? data, OcpiStatusCode statusCode = OcpiStatusCode.Success)
        : this(data, (int)statusCode) { }

    public OcpiResponse(object? data, int statusCode) : this()
    {
        Data = data;
        StatusCode = statusCode;
        TryConfigureStatusMessage(statusCode);
    }

    private void TryConfigureStatusMessage(int statusCode)
    {
        var defined = Enum.IsDefined(typeof(OcpiStatusCode), statusCode);
        if (!defined) return;

        var status = (OcpiStatusCode)statusCode;
        StatusMessage = status.ToMemberValue();
    }
}
