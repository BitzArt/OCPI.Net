using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OCPI.Services;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace OCPI;

public static class AddOcpiControllersExtension
{
    public static WebApplicationBuilder AddOcpiControllers(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.PropertyNamingPolicy
            = JsonNamingPolicy.CamelCase;

            options.JsonSerializerOptions.DefaultIgnoreCondition
            = JsonIgnoreCondition.WhenWritingNull;

            options.JsonSerializerOptions.Converters.Add(new JsonStringEnumMemberConverter());
            options.JsonSerializerOptions.Converters.Add(new OcpiDateTimeConverter());
        });

        builder.Services.AddScoped<PageResponseService>();

        return builder;
    }
}
