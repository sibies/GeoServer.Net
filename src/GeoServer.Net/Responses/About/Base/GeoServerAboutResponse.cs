using System.Text.Json.Serialization;

namespace GeoServer.Net.Responses.About.Base;

public class GeoServerAboutResponse<TResource>
{
    [JsonPropertyName("resource")]
    public TResource[] Resources { get; set; }
}