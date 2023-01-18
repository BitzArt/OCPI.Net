using Microsoft.Extensions.Options;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OCPI.Endpoints;

internal static class OcpiJsonSerializerOptions
{
    public static JsonSerializerOptions? Instance = GenerateOptions();

    private static JsonSerializerOptions GenerateOptions()
    {
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        options.Converters.Add(new JsonStringEnumMemberConverter());
        options.Converters.Add(new OcpiDateTimeConverter());

        return options;
    }
}
