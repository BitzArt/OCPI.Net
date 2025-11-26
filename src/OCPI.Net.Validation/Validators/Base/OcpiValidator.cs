using BitzArt.EnumToMemberValue;
using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal abstract class OcpiValidator<T>(OcpiValidationContext validationContext) : ActionValidator<T>, IOcpiValidator<T>
{
    public OcpiVersion OcpiVersion => validationContext.OcpiVersion!.Value;

    public IConditionBuilder WhenOcpiVersionAbove(string version, Action action)
        => WhenOcpiVersionAbove(version.ToEnum<OcpiVersion>(), action);

    public IConditionBuilder WhenOcpiVersionAbove(OcpiVersion version, Action action)
    {
        return When((T x) => OcpiVersion > version, action);
    }

    public IConditionBuilder WhenOcpiVersionBelow(string version, Action action)
        => WhenOcpiVersionBelow(version.ToEnum<OcpiVersion>(), action);

    public IConditionBuilder WhenOcpiVersionBelow(OcpiVersion version, Action action)
    {
        return When((T x) => OcpiVersion < version, action);
    }
}
