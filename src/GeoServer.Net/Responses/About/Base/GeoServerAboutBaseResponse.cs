using System.Text.Json.Serialization;

namespace GeoServer.Net.Responses.About.Base;

public abstract class GeoServerAboutBaseResponse<TModel>
{
    [JsonPropertyName("about")]
    public GeoServerAboutResponse<TModel> About { get; set; }
}