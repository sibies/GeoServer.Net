using System.Text.Json.Serialization;

namespace GeoServer.Net.Responses.Layers;

public class GeoServerLayersListResponse
{
    [JsonPropertyName("layers")]
    public Layers Layers { get; set; }
}


public class Layers
{
    [JsonPropertyName("layer")]
    public Layer[] Layer { get; set; }
}

public class Layer
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("href")]
    public string Href { get; set; }
}
