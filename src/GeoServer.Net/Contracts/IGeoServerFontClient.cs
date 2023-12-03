using GeoServer.Net.Responses.Fonts;

namespace GeoServer.Net.Contracts;

public interface IGeoServerFontClient
{
    /// <summary>
    /// A font is a set of characters that can be used in a style for displaying labels.
    /// https://docs.geoserver.org/latest/en/api/#1.0.0/fonts.yaml
    /// </summary>
    /// <returns></returns>
    Task<GeoServerFontsListResponse> GetFontsListAsync();
}