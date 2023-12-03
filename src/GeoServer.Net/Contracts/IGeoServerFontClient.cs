using GeoServer.Net.Responses.Fonts;

namespace GeoServer.Net.Contracts;

/// <summary>
/// A font is a set of characters that can be used in a style for displaying labels.
/// https://docs.geoserver.org/latest/en/api/#1.0.0/fonts.yaml
/// </summary>
public interface IGeoServerFontClient
{
    Task<GeoServerFontsListResponse> GetFontsListAsync();
}