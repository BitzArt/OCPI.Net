using BitzArt.ApiExceptions;
using OCPI.Exceptions;

namespace OCPI;

public static partial class OcpiException
{
    /// <summary>
    /// Creates a new <see cref="CustomOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="ocpiStatusCode">OCPI Status Code</param>
    /// <param name="ocpiLayerHttpStatusCode">HttpStatusCode for responses within OCPI Layer</param>
    /// <param name="apiStatusCode">HttpStatusCode for responses outside of OCPI Layer</param>
    /// <param name="innerException">Inner exception</param>
    public static CustomOcpiException Custom
        (string message, OcpiStatusCode ocpiStatusCode, ApiStatusCode ocpiLayerHttpStatusCode = ApiStatusCode.OK, ApiStatusCode apiStatusCode = ApiStatusCode.Error, Exception? innerException = null)
        => new(message, ocpiStatusCode, ocpiLayerHttpStatusCode, apiStatusCode, innerException);

    /// <summary>
    /// Creates a new <see cref="CustomOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="ocpiStatusCode">OCPI Status Code</param>
    /// <param name="ocpiLayerHttpStatusCode">HttpStatusCode for responses within OCPI Layer</param>
    /// <param name="apiStatusCode">HttpStatusCode for responses outside of OCPI Layer</param>
    /// <param name="innerException">Inner exception</param>
    public static CustomOcpiException Custom
        (string message, int ocpiStatusCode, ApiStatusCode ocpiLayerHttpStatusCode = ApiStatusCode.OK, ApiStatusCode apiStatusCode = ApiStatusCode.Error, Exception? innerException = null)
        => new(message, ocpiStatusCode, ocpiLayerHttpStatusCode, apiStatusCode, innerException);

    /// <summary>
    /// Creates a new <see cref="CustomOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="ocpiStatusCode">OCPI Status Code</param>
    /// <param name="ocpiLayerHttpStatusCode">HttpStatusCode for responses within OCPI Layer</param>
    /// <param name="apiStatusCode">HttpStatusCode for responses outside of OCPI Layer</param>
    /// <param name="innerException">Inner exception</param>
    public static CustomOcpiException Custom
        (string message, int ocpiStatusCode, int ocpiLayerHttpStatusCode, int apiStatusCode, Exception? innerException = null)
        => new(message, ocpiStatusCode, ocpiLayerHttpStatusCode, apiStatusCode, innerException);

    /// <summary>
    /// Creates a new <see cref="ClientApiErrorOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public static ClientApiErrorOcpiException ClientApiError
        (string message = ClientApiErrorOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);

    /// <summary>
    /// Creates a new <see cref="ClientErrorOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public static ClientErrorOcpiException ClientError
        (string message = ClientErrorOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);

    /// <summary>
    /// Creates a new <see cref="InvalidParametersOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public static InvalidParametersOcpiException InvalidParameters
        (string message = InvalidParametersOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);

    /// <summary>
    /// Creates a new <see cref="MissingEndpointOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public static MissingEndpointOcpiException MissingEndpoint
        (string message = MissingEndpointOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);

    /// <summary>
    /// Creates a new <see cref="NotEnoughInformationOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public static NotEnoughInformationOcpiException NotEnoughInformation
        (string message = NotEnoughInformationOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);

    /// <summary>
    /// Creates a new <see cref="ServerErrorOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public static ServerErrorOcpiException ServerError
        (string message = ServerErrorOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);

    /// <summary>
    /// Creates a new <see cref="UnauthorizedOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public static UnauthorizedOcpiException Unauthorized
        (string message = UnauthorizedOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);

    /// <summary>
    /// Creates a new <see cref="UnknownLocationOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public static UnknownLocationOcpiException UnknownLocation
        (string message = UnknownLocationOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);

    /// <summary>
    /// Creates a new <see cref="UnknownTokenOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public static UnknownTokenOcpiException UnknownToken
        (string message = UnknownTokenOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);

    /// <summary>
    /// Creates a new <see cref="UnsupportedVersionOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public static UnsupportedVersionOcpiException UnsupportedVersion
        (string message = UnsupportedVersionOcpiException.DefaultMessage, Exception? innerException = null)
        => new(message, innerException);
}
