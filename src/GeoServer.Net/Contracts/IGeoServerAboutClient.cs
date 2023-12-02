using GeoServer.Net.Responses.About;

namespace GeoServer.Net.Contracts;

public interface IGeoServerAboutClient
{
    /// <summary>
    /// Retrieve the versions of the main components: GeoServer, GeoTools, and GeoWebCache
    /// http://localhost:8080/geoserver/rest/about/version.json
    /// </summary>
    /// <returns></returns>
    Task<GeoServerAboutVersionResponse> GetVersionAsync();
    /// <summary>
    /// Retrieve the full manifest and subsets of the manifest as known to the ClassLoader
    /// http://localhost:8080/geoserver/rest/about/manifest.json
    /// </summary>
    /// <returns></returns>
    Task<GeoServerAboutManifestResponse> GetManifestAsync();
    /// <summary>
    /// It is possible to request the available system information (monitoring data) through the GeoServer REST API.
    /// The supported formats are XML, JSON and HTML.
    /// https://docs.geoserver.org/stable/en/user/rest/about.html#system-status
    /// </summary>
    /// <returns></returns>
    Task<GeoServerAboutSystemStatusResponse> GetSystemStatusAsync();
}