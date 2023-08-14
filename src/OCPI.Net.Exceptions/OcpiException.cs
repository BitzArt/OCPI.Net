using BitzArt.ApiExceptions;
using OCPI.Exceptions;

namespace OCPI;

public static partial class OcpiException
{
    public static CustomOcpiException Custom
        (string message, OcpiStatusCode ocpiStatusCode, ApiStatusCode apiStatusCode = ApiStatusCode.OK, Exception? innerException = null)
        => new(message, ocpiStatusCode, apiStatusCode, innerException);

    public static CustomOcpiException Custom
        (string message, int ocpiStatusCode, ApiStatusCode apiStatusCode = ApiStatusCode.OK, Exception? innerException = null)
        => new(message, ocpiStatusCode, apiStatusCode, innerException);

    public static CustomOcpiException Custom
        (string message, int ocpiStatusCode, int httpStatusCode, Exception? innerException = null)
        => new(message, ocpiStatusCode, httpStatusCode, innerException);

    public static ClientApiErrorOcpiException ClientApiError
        (string message = ClientApiErrorOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);

    public static ClientErrorOcpiException ClientError
        (string message = ClientErrorOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);

    public static InvalidParametersOcpiException InvalidParameters
        (string message = InvalidParametersOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);

    public static MissingEndpointOcpiException MissingEndpoint
        (string message = MissingEndpointOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);

    public static NotEnoughInformationOcpiException NotEnoughInformation
        (string message = NotEnoughInformationOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);

    public static ServerErrorOcpiException ServerError
        (string message = ServerErrorOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);

    public static UnauthorizedOcpiException Unauthorized
        (string message = UnauthorizedOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);

    public static UnknownLocationOcpiException UnknownLocation
        (string message = UnknownLocationOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);

    public static UnknownTokenOcpiException UnknownToken
        (string message = UnknownTokenOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);

    public static UnsupportedVersionOcpiException UnsupportedVersion
        (string message = UnsupportedVersionOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);
}
