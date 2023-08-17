using BitzArt.ApiExceptions;

namespace OCPI.Exceptions;

public class CustomOcpiException : OcpiExceptionBase
{
    /// <summary>
    /// Creates a new <see cref="CustomOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="ocpiStatusCode">OCPI Status Code</param>
    /// <param name="ocpiLayerHttpStatusCode">HttpStatusCode for responses within OCPI Layer</param>
    /// <param name="apiStatusCode">HttpStatusCode for responses outside of OCPI Layer</param>
    /// <param name="innerException">Inner exception</param>
    public CustomOcpiException(string message, OcpiStatusCode ocpiStatusCode, ApiStatusCode ocpiLayerHttpStatusCode, ApiStatusCode apiStatusCode = ApiStatusCode.Error, Exception? innerException = null)
        : base(message, ocpiStatusCode, ocpiLayerHttpStatusCode, apiStatusCode, innerException) { }

    /// <summary>
    /// Creates a new <see cref="CustomOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="ocpiStatusCode">OCPI Status Code</param>
    /// <param name="ocpiLayerHttpStatusCode">HttpStatusCode for responses within OCPI Layer</param>
    /// <param name="apiStatusCode">HttpStatusCode for responses outside of OCPI Layer</param>
    /// <param name="innerException">Inner exception</param>
    public CustomOcpiException(string message, int ocpiStatusCode, ApiStatusCode ocpiLayerHttpStatusCode, ApiStatusCode apiStatusCode = ApiStatusCode.Error, Exception? innerException = null)
        : base(message, ocpiStatusCode, ocpiLayerHttpStatusCode, apiStatusCode, innerException) { }

    /// <summary>
    /// Creates a new <see cref="CustomOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="ocpiStatusCode">OCPI Status Code</param>
    /// <param name="ocpiLayerHttpStatusCode">HttpStatusCode for responses within OCPI Layer</param>
    /// <param name="apiStatusCode">HttpStatusCode for responses outside of OCPI Layer</param>
    /// <param name="innerException">Inner exception</param>
    public CustomOcpiException(string message, int ocpiStatusCode, int ocpiLayerHttpStatusCode, int apiStatusCode, Exception? innerException = null)
        : base(message, ocpiStatusCode, ocpiLayerHttpStatusCode, apiStatusCode, innerException) { }
}
