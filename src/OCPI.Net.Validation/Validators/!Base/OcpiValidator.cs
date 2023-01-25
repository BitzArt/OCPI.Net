namespace OCPI.Validation;

public abstract class OcpiValidator<T> : JsonValidator<T>
{
    private readonly string _httpMethod;

    protected OcpiValidator(string httpMethod)
    {
        _httpMethod = httpMethod;
    }

    protected bool IsPost => _httpMethod == "POST";
    protected bool IsPut => _httpMethod == "PUT";
    protected bool IsPatch => _httpMethod == "PATCH";
}
