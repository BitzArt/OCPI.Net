using FluentValidation;

namespace OCPI.Contracts;

public interface IOcpiValidator
{
    public OcpiVersion OcpiVersion { get; internal set; }
}

public interface IOcpiValidator<T> : IOcpiValidator, IActionValidator, IValidator<T> { }
