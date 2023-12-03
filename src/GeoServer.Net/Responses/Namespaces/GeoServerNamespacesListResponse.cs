using System.Text.Json.Serialization;

namespace GeoServer.Net.Responses.Namespaces;

public class GeoServerNamespacesListResponse
{
    [JsonPropertyName("namespaces")]
    public Namespaces Namespaces { get; set; }
}

public class Namespaces
{
    [JsonPropertyName("namespace")]
    public Namespace[] Namespace { get; set; }
}

public class Namespace
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("href")]
    public string Href { get; set; }
}
