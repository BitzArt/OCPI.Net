using OCPI.Contracts;
using OCPI.Exceptions;

namespace OCPI;

public static partial class OcpiException
{
    public static CustomOcpiException Custom
        (string message, OcpiStatusCode ocpiStatusCode)
        => new(message, ocpiStatusCode);

    public static ClientErrorOcpiException ClientError
        (string message = ClientErrorOcpiException.DefaultMessage)
        => new(message);

    public static InvalidParametersOcpiException InvalidParameters
        (string message = InvalidParametersOcpiException.DefaultMessage)
        => new(message);

    public static NotEnoughInformationOcpiException NotEnoughInformation
        (string message = NotEnoughInformationOcpiException.DefaultMessage)
        => new(message);

    public static UnknownLocationOcpiException UnknownLocation
        (string message = UnknownLocationOcpiException.DefaultMessage)
        => new(message);

    public static UnknownTokenOcpiException UnknownToken
        (string message = UnknownTokenOcpiException.DefaultMessage)
        => new(message);

    public static ServerErrorOcpiException ServerError
        (string message = ServerErrorOcpiException.DefaultMessage)
        => new(message);

    public static ClientApiErrorOcpiException ClientApiError
        (string message = ClientApiErrorOcpiException.DefaultMessage)
        => new(message);

    public static UnsupportedVersionOcpiException UnsupportedVersion
        (string message = UnsupportedVersionOcpiException.DefaultMessage)
        => new(message);

    public static MissingEndpointOcpiException MissingEndpoint
        (string message = MissingEndpointOcpiException.DefaultMessage)
        => new(message);
}
