using System.Text.Json.Serialization;

namespace GeoServer.Net.Responses.Fonts;

public class GeoServerFontsListResponse
{
    [JsonPropertyName("fonts")]
    public string[] Fonts { get; set; }
}