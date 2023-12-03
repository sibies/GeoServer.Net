using GeoServer.Net.Responses.Namespaces;

namespace GeoServer.Net.Contracts;

/// <summary>
/// A namespace is a uniquely identifiable grouping of feature types. It is identified by a prefix and a URI.
/// https://docs.geoserver.org/latest/en/api/#1.0.0/namespaces.yaml
/// </summary>
public interface IGeoServerNamespaceClient
{
    Task<GeoServerNamespacesListResponse> GetNamespacesListAsync();
}