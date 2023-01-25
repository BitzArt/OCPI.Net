using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OCPI.Services;
using System.Text.Json.Serialization;
using System.Text.Json;
using BitzArt.ApiExceptions;

namespace OCPI;

public static class AddOcpiControllersExtension
{
    public static WebApplicationBuilder AddOcpiControllers(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers()
            .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.PropertyNamingPolicy
            = JsonNamingPolicy.CamelCase;

            options.JsonSerializerOptions.DefaultIgnoreCondition
            = JsonIgnoreCondition.WhenWritingNull;

            options.JsonSerializerOptions.Converters.Add(new JsonStringEnumMemberConverter());
            options.JsonSerializerOptions.Converters.Add(new OcpiDateTimeConverter());
        }).ConfigureApiBehaviorOptions(options =>
        {
            options.InvalidModelStateResponseFactory = context =>
            {
                var errors = context.ModelState.Values
                .SelectMany(x => x.Errors)
                .Select(x => x.ErrorMessage);

                var exception = OcpiException.InvalidParameters("Failed to parse request data");
                exception.Payload.AddData(new { errors });

                throw exception;
            };
        });

        builder.Services.AddScoped<PageResponseService>();

        return builder;
    }
}
