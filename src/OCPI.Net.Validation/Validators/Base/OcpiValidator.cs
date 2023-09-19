using BitzArt.EnumToMemberValue;
using FluentValidation;

namespace OCPI.Contracts;

internal abstract class OcpiValidator<T> : ActionValidator<T>
{
    protected readonly OcpiVersion OcpiVersion;

    protected OcpiValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType)
    {
        OcpiVersion = ocpiVersion;
    }

    public IConditionBuilder WhenOcpiVersionAbove(string version, Action action)
        => WhenOcpiVersionAbove(version.ToEnum<OcpiVersion>(), action);

    public IConditionBuilder WhenOcpiVersionAbove(OcpiVersion version, Action action)
    {
        return When((T x) => version > OcpiVersion, action);
    }

    public IConditionBuilder WhenOcpiVersionBelow(string version, Action action)
        => WhenOcpiVersionBelow(version.ToEnum<OcpiVersion>(), action);

    public IConditionBuilder WhenOcpiVersionBelow(OcpiVersion version, Action action)
    {
        return When((T x) => version < OcpiVersion, action);
    }
}
