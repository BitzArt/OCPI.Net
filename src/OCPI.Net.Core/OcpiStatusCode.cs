namespace OCPI
{
    public enum OcpiStatusCode : int
    {
        Success = 1000,

        ClientError = 2000,
        InvalidParameters = 2001,
        NotEnoughInformation = 2002,
        UnknownLocation = 2003,
        UnknownToken = 2004,

        ServerError = 3000,
        ClientApiError = 3001,
        UnsupportedVersion = 3002,
        MissingEndpoint = 3003,
    }
}
