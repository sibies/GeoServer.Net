using GeoServer.Net.Responses.Styles;

namespace GeoServer.Net.Contracts;

/// <summary>
/// A style describes how a resource is symbolized or rendered by the Web Map Service.
/// https://docs.geoserver.org/latest/en/api/#1.0.0/styles.yaml
/// </summary>
public interface IGeoServerStyleClient
{
    Task<GeoServerStylesListResponse> GetStylesListAsync();
}