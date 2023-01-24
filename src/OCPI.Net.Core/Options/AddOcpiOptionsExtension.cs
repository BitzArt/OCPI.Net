using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace OCPI;

public static class AddOcpiOptionsExtension
{
    public static WebApplicationBuilder AddOcpiOptions(this WebApplicationBuilder builder)
    {
        var options = builder.Configuration
            .GetRequiredSection(OcpiOptions.SectionName)
            .Get<OcpiOptions>()!;

        builder.Services.AddSingleton(options);

        return builder;
    }
}
