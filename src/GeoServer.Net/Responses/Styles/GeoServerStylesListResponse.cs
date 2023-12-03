using System.Text.Json.Serialization;

namespace GeoServer.Net.Responses.Styles;

public class GeoServerStylesListResponse
{
    [JsonPropertyName("styles")]
    public Styles Styles { get; set; }
}


public class Styles
{
    [JsonPropertyName("style")]
    public Style[] Style { get; set; }
}

public class Style
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("href")]
    public string Href { get; set; }
}
