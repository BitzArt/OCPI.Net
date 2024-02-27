using BitzArt.ApiExceptions;

namespace OCPI.Exceptions;

/// <summary>
/// Creates a new <see cref="OcpiExceptionBase"/>
/// </summary>
/// <param name="message">Message to be displayed</param>
/// <param name="ocpiStatusCode">OCPI Status Code</param>
/// <param name="ocpiLayerHttpStatusCode">HttpStatusCode for responses within OCPI Layer</param>
/// <param name="apiStatusCode">HttpStatusCode for responses outside of OCPI Layer</param>
/// <param name="innerException">Inner exception</param>
public abstract class OcpiExceptionBase(string message, int ocpiStatusCode, int ocpiLayerHttpStatusCode, int apiStatusCode, Exception? innerException = null) : ApiExceptionBase(message, apiStatusCode, innerException: innerException)
{
    /// <summary>
    /// OCPI Status Code. Used when displaying error responses within OCPI Layer.
    /// </summary>
    public int OcpiStatus { get; set; } = ocpiStatusCode;

    /// <summary>
    /// Used as an HttpStatusCode in responses within OCPI Layer.
    /// <br>While <see cref="ApiExceptionBase.StatusCode"/> is used as an HttpStatusCode outside of OCPI layer.</br>
    /// </summary>
    public int OcpiLayerHttpStatusCode { get; set; } = ocpiLayerHttpStatusCode;

    /// <summary>
    /// Creates a new <see cref="OcpiExceptionBase"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="ocpiStatusCode">OCPI Status Code</param>
    /// <param name="ocpiLayerHttpStatusCode">HttpStatusCode for responses within OCPI Layer</param>
    /// <param name="apiStatusCode">HttpStatusCode for responses outside of OCPI Layer</param>
    /// <param name="innerException">Inner exception</param>
    public OcpiExceptionBase(string message, OcpiStatusCode ocpiStatusCode, ApiStatusCode ocpiLayerHttpStatusCode = ApiStatusCode.OK, ApiStatusCode apiStatusCode = ApiStatusCode.Error, Exception? innerException = null)
        : this(message, (int)ocpiStatusCode, ocpiLayerHttpStatusCode, apiStatusCode, innerException) { }

    /// <summary>
    /// Creates a new <see cref="OcpiExceptionBase"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="ocpiStatusCode">OCPI Status Code</param>
    /// <param name="ocpiLayerHttpStatusCode">HttpStatusCode for responses within OCPI Layer</param>
    /// <param name="apiStatusCode">HttpStatusCode for responses outside of OCPI Layer</param>
    /// <param name="innerException">Inner exception</param>
    public OcpiExceptionBase(string message, int ocpiStatusCode, ApiStatusCode ocpiLayerHttpStatusCode = ApiStatusCode.OK, ApiStatusCode apiStatusCode = ApiStatusCode.Error, Exception? innerException = null)
        : this(message, ocpiStatusCode, (int)ocpiLayerHttpStatusCode, (int)apiStatusCode, innerException) { }
}
