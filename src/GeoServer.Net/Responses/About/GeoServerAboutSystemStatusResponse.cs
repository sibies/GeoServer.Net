using System.Text.Json.Serialization;

namespace GeoServer.Net.Responses.About;

public class GeoServerAboutSystemStatusResponse
{
    [JsonPropertyName("metrics")]
    public Metrics Metrics { get; set; }
}

public class Metrics
{
    [JsonPropertyName("metric")]
    public Metric[] Metric { get; set; }
}

public class Metric
{
    [JsonPropertyName("available")]
    public bool Available { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("unit")]
    public string Unit { get; set; }
    [JsonPropertyName("category")]
    public string Category { get; set; }
    [JsonPropertyName("identifier")]
    public string Identifier { get; set; }
    [JsonPropertyName("priority")]
    public int Priority { get; set; }
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
