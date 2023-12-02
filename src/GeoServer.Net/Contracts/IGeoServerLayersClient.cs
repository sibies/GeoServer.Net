using GeoServer.Net.Responses.Layers;

namespace GeoServer.Net.Contracts;

/// <summary>
/// https://docs.geoserver.org/latest/en/api/#1.0.0/layers.yaml
/// </summary>
public interface IGeoServerLayersClient
{
    /// <summary>
    /// Displays a list of all layers on the server. You must use the “Accept:” header to specify format or append an extension to the endpoint (example “/layers.xml” for XML)
    /// http://localhost:8080/geoserver/rest/layers.json
    /// </summary>
    /// <returns></returns>
    Task<GeoServerLayersListResponse> GetLayersListAsync();
}