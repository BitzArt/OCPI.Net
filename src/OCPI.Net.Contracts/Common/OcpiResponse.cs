using BitzArt.EnumToMemberValue;
using OCPI.Exceptions;
using System;
using System.Text.Json.Serialization;

namespace OCPI;

public class OcpiResponse<TData> : OcpiResponse
{
    [JsonPropertyName("data")]
    public new TData Data { get; set; }
}

public class OcpiResponse
{
    [JsonPropertyName("data")]
    public object Data { get; set; }

    [JsonPropertyName("status_code")]
    public int StatusCode { get; set; }

    [JsonPropertyName("status_message")]
    public string StatusMessage { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime Created { get; set; }

    public OcpiResponse() { }

    public OcpiResponse(object data, OcpiStatusCode statusCode = OcpiStatusCode.Success)
        : this(data, (int)statusCode) { }

    public OcpiResponse(object data, int statusCode)
    {
        Data = data;
        StatusCode = statusCode;
        Created = DateTime.UtcNow;

        TryConfigureStatusMessage(statusCode);
    }

    private void TryConfigureStatusMessage(int statusCode)
    {
        var defined = Enum.IsDefined(typeof(OcpiStatusCode), statusCode);
        if (!defined) return;

        var status = (OcpiStatusCode)statusCode;
        StatusMessage = status.ToMemberValue();
    }

    public static OcpiResponse FromException(Exception exception)
    {
        if (exception is OcpiExceptionBase ocpiException) return new(ocpiException.Message, ocpiException.OcpiStatusCode);

        if (exception.InnerException != null)
        {
            var data = new
            {
                message = exception.Message,
                inner = exception.InnerException.Message
            };
            return new(data, OcpiStatusCode.ServerError);
        }

        return new(exception.Message, OcpiStatusCode.ServerError);
    }
}
