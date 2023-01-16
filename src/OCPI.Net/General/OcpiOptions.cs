using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace OCPI
{
    public class OcpiOptions
    {
        public const string SectionName = "OCPI";

        public string BaseServiceUrl { get; set; } = null!;
    }

    public static class AddOcpiOptionsExtension
    {
        public static WebApplicationBuilder AddOcpiOptions(this WebApplicationBuilder builder)
        {
            builder.Services.AddOcpiOptions(builder.Configuration);
            return builder;
        }

        public static IServiceCollection AddOcpiOptions(this IServiceCollection services, IConfiguration configuration)
        {
            var options = configuration
                .GetRequiredSection(OcpiOptions.SectionName)
                .Get<OcpiOptions>()!;

            return services.AddOcpiOptions(options);
        }

        public static IServiceCollection AddOcpiOptions(this IServiceCollection services, OcpiOptions options)
        {
            return services.AddSingleton(options);
        }
    }
}
