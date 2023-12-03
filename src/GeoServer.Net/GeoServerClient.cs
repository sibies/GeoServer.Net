using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using GeoServer.Net.Constants;
using GeoServer.Net.Contracts;
using GeoServer.Net.Exceptions;
using GeoServer.Net.Responses.About;
using GeoServer.Net.Responses.Fonts;
using GeoServer.Net.Responses.Layers;

namespace GeoServer.Net;

/// <summary>
/// https://docs.geoserver.org/stable/en/user/rest/index.html
/// </summary>
public class GeoServerClient: HttpClient, IGeoServerClient
{
    private readonly string _url;

    public GeoServerClient(string url)
        :this(url,string.Empty,string.Empty)
    {
    }

    public GeoServerClient(string url, string username, string password)
    {
        _url = url;
        var baseUri = new Uri(_url);
        BaseAddress = baseUri;
        DefaultRequestHeaders.Clear();
        DefaultRequestHeaders.ConnectionClose = true;

        if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
        {
            var authenticationString = $"{username}:{password}";
            var base64EncodedAuthenticationString = Convert.ToBase64String(Encoding.UTF8.GetBytes(authenticationString));

            DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
        }
    }

    /// <summary>
    /// Retrieve the versions of the main components: GeoServer, GeoTools, and GeoWebCache
    /// https://docs.geoserver.org/stable/en/user/rest/about.html
    /// </summary>
    /// <returns></returns>
    public async Task<GeoServerAboutVersionResponse> GetVersionAsync()
    {
        var response = await GetAsync(_url + ApiConsts.Endpoints.About.VersionApiPath);
        if(!response.IsSuccessStatusCode) throw new GeoServerHttpRequestException(response.StatusCode.ToString());
        //var result = await response.Content.ReadAsStringAsync();
        var result = await response.Content.ReadFromJsonAsync<GeoServerAboutVersionResponse>();
        return result;
    }

    public async Task<GeoServerAboutManifestResponse> GetManifestAsync()
    {
        var response = await GetAsync(_url + ApiConsts.Endpoints.About.ManifestApiPath);
        if (!response.IsSuccessStatusCode) throw new GeoServerHttpRequestException(response.StatusCode.ToString());
        //var result = await response.Content.ReadAsStringAsync();
        var result = await response.Content.ReadFromJsonAsync<GeoServerAboutManifestResponse>();
        return result;
    }

    public async Task<GeoServerAboutSystemStatusResponse> GetSystemStatusAsync()
    {
        var response = await GetAsync(_url + ApiConsts.Endpoints.About.SystemStatusApiPath);
        if (!response.IsSuccessStatusCode) throw new GeoServerHttpRequestException(response.StatusCode.ToString());
        //var result = await response.Content.ReadAsStringAsync();
        var result = await response.Content.ReadFromJsonAsync<GeoServerAboutSystemStatusResponse>();
        return result;
    }

    public async Task<GeoServerLayersListResponse> GetLayersListAsync()
    {
        var response = await GetAsync(_url + ApiConsts.Endpoints.Layers.GetLayersApiPath);
        if (!response.IsSuccessStatusCode) throw new GeoServerHttpRequestException(response.StatusCode.ToString());
        //var result = await response.Content.ReadAsStringAsync();
        var result = await response.Content.ReadFromJsonAsync<GeoServerLayersListResponse>();
        return result;
    }

    public async Task<GeoServerFontsListResponse> GetFontsListAsync()
    {
        var response = await GetAsync(_url + ApiConsts.Endpoints.Fonts.GetFontsApiPath);
        if (!response.IsSuccessStatusCode) throw new GeoServerHttpRequestException(response.StatusCode.ToString());
        //var result = await response.Content.ReadAsStringAsync();
        var result = await response.Content.ReadFromJsonAsync<GeoServerFontsListResponse>();
        return result;
    }
}