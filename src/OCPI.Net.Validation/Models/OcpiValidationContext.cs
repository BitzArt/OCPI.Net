using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace OCPI.Validation;

public class OcpiValidationContext(ActionType actionType, OcpiVersion? ocpiVersion)
{
    public ActionType ActionType { get; set; } = actionType;
    public OcpiVersion? OcpiVersion { get; set; } = ocpiVersion;

    public OcpiValidationContext(HttpRequest request)
        : this(request.Method.ToActionType(), request.GetCurrentOcpiVersion())
    { }
}
