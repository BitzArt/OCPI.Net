namespace OCPI.Validation;

public abstract class OcpiValidator<T> : JsonValidator<T>
{
    protected readonly string HttpMethod;

    protected OcpiValidator(string httpMethod)
    {
        HttpMethod = httpMethod;
    }

    protected bool IsPost => HttpMethod == "POST";
    protected bool IsPut => HttpMethod == "PUT";
    protected bool IsPatch => HttpMethod == "PATCH";
}
