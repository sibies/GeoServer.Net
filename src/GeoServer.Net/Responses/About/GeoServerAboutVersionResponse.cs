using System.Text.Json.Serialization;
using GeoServer.Net.Responses.About.Base;

namespace GeoServer.Net.Responses.About;

public class GeoServerAboutVersionResponse: GeoServerAboutBaseResponse<Resource>
{
}



public class Resource
{
    [JsonPropertyName("@name")]
    public string Name { get; set; }
    [JsonPropertyName("Build-Timestamp")]
    public string BuildTimestamp { get; set; }
    [JsonPropertyName("Version")]
    public object Version { get; set; }
    [JsonPropertyName("Git-Revision")]
    public string GitRevision { get; set; }
}
