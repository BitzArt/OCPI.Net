using BitzArt.EnumToMemberValue;
using Microsoft.AspNetCore.Http;

namespace OCPI;

internal static class GetCurrentOcpiVersionExtension
{
    public static OcpiVersion GetCurrentOcpiVersion(this HttpRequest request)
    {
        var path = request.Path.Value!.TrimStart('/');
        var versionLength = path.IndexOf('/');
        if (versionLength == -1) versionLength = path.Length;

        var versionString = path.Substring(0, versionLength);

        var result = versionString.ToEnum<OcpiVersion>();
        return result;
    }
}
