namespace OCPI;

public class OcpiOptions
{
    public const string SectionName = "OCPI";

    public required string BaseServiceUrl { get; set; }
    public string VersionListTemplate { get; set; } = "[BaseServiceUrl]/versions/[Version]";
    public string ModuleTemplate { get; set; } = "[BaseServiceUrl]/[ModuleRoute]";
}
