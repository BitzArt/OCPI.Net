using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OCPI;

public static class ConfigureOcpiJsonExtension
{
    public static WebApplicationBuilder ConfigureOcpiJson(this WebApplicationBuilder builder)
    {
        builder.Services.ConfigureHttpJsonOptions(options =>
        {
            options.SerializerOptions
            .PropertyNamingPolicy = JsonNamingPolicy.CamelCase;

            options.SerializerOptions
                .DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;

            options.SerializerOptions
            .Converters.Add(new JsonStringEnumMemberConverter());

            options.SerializerOptions
            .Converters.Add(new OcpiDateTimeConverter());
        });

        return builder;
    }
}
