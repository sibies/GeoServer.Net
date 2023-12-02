using GeoServer.Net.Responses.About.Base;
using System.Text.Json.Serialization;

namespace GeoServer.Net.Responses.About;

public class GeoServerAboutManifestResponse:GeoServerAboutBaseResponse<Manifest>
{
    
}

public class Manifest
{
    [JsonPropertyName("@name")]
    public string Name { get; set; }
    [JsonPropertyName("Archiver-Version")]
    public string ArchiverVersion { get; set; }
    [JsonPropertyName("Bundle-License")]
    public string BundleLicense { get; set; }
    [JsonPropertyName("Specification-Version")]
    public object SpecificationVersion { get; set; }
}
