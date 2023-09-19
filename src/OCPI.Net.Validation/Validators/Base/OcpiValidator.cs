using FluentValidation;

namespace OCPI.Contracts;

internal abstract class OcpiValidator<T> : ActionValidator<T>
{
    protected readonly OcpiVersion OcpiVersion;

    protected OcpiValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType)
    {
        OcpiVersion = ocpiVersion;
    }

    public IConditionBuilder When(OcpiVersion ocpiVersion, Action action)
    {
        return When((T x) => OcpiVersion == ocpiVersion, action);
    }

    public IConditionBuilder Unless(OcpiVersion ocpiVersion, Action action)
    {
        return Unless((T x) => OcpiVersion == ocpiVersion, action);
    }
}
