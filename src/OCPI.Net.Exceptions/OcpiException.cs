using BitzArt.ApiExceptions;
using OCPI.Exceptions;

namespace OCPI;

public static partial class OcpiException
{
    public static CustomOcpiException Custom
        (string message, OcpiStatusCode ocpiStatusCode, ApiStatusCode apiStatusCode = ApiStatusCode.OK)
        => new(message, ocpiStatusCode, apiStatusCode);

    public static CustomOcpiException Custom
        (string message, int ocpiStatusCode, ApiStatusCode apiStatusCode = ApiStatusCode.OK)
        => new(message, ocpiStatusCode, apiStatusCode);

    public static CustomOcpiException Custom
        (string message, int ocpiStatusCode, int httpStatusCode)
        => new(message, ocpiStatusCode, httpStatusCode);

    public static ClientApiErrorOcpiException ClientApiError
        (string message = ClientApiErrorOcpiException.DefaultMessage)
        => new(message);

    public static ClientErrorOcpiException ClientError
        (string message = ClientErrorOcpiException.DefaultMessage)
        => new(message);

    public static InvalidParametersOcpiException InvalidParameters
        (string message = InvalidParametersOcpiException.DefaultMessage)
        => new(message);

    public static MissingEndpointOcpiException MissingEndpoint
        (string message = MissingEndpointOcpiException.DefaultMessage)
        => new(message);

    public static NotEnoughInformationOcpiException NotEnoughInformation
        (string message = NotEnoughInformationOcpiException.DefaultMessage)
        => new(message);

    public static ServerErrorOcpiException ServerError
        (string message = ServerErrorOcpiException.DefaultMessage)
        => new(message);

    public static UnauthorizedOcpiException Unauthorized
        (string message = UnauthorizedOcpiException.DefaultMessage)
        => new(message);

    public static UnknownLocationOcpiException UnknownLocation
        (string message = UnknownLocationOcpiException.DefaultMessage)
        => new(message);

    public static UnknownTokenOcpiException UnknownToken
        (string message = UnknownTokenOcpiException.DefaultMessage)
        => new(message);

    public static UnsupportedVersionOcpiException UnsupportedVersion
        (string message = UnsupportedVersionOcpiException.DefaultMessage)
        => new(message);
}
