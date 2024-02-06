using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace OCPI.Validation;

public class OcpiValidationContext
{
    public ActionType ActionType { get; set; }
    public OcpiVersion? OcpiVersion { get; set; }

    public OcpiValidationContext(ActionType actionType, OcpiVersion? ocpiVersion)
    {
        ActionType = actionType;
        OcpiVersion = ocpiVersion;
    }

    public OcpiValidationContext(HttpRequest request)
        : this(request.Method.ToActionType(), request.GetCurrentOcpiVersion())
    { }
}
