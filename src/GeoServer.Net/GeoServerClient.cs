using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using GeoServer.Net.Constants;
using GeoServer.Net.Contracts;
using GeoServer.Net.Exceptions;
using GeoServer.Net.Responses.About;
using GeoServer.Net.Responses.Fonts;
using GeoServer.Net.Responses.Layers;
using GeoServer.Net.Responses.Namespaces;
using GeoServer.Net.Responses.Styles;

namespace GeoServer.Net;

/// <summary>
/// https://docs.geoserver.org/stable/en/user/rest/index.html
/// https://docs.geoserver.org/stable/en/user/rest/api/index.html
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

        //https://docs.geoserver.org/stable/en/user/rest/api/details.html
        DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
        {
            Autentificate(username, password);
        }
    }

    private void Autentificate(string username, string password)
    {
        var authenticationString = $"{username}:{password}";
        var base64EncodedAuthenticationString = Convert.ToBase64String(Encoding.UTF8.GetBytes(authenticationString));
        DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
    }

    private async Task<TResponse> GetAsync<TResponse>(string apiEndpoint)
    {
        var response = await GetAsync(_url + apiEndpoint);
        if (!response.IsSuccessStatusCode) throw new GeoServerHttpRequestException(response.StatusCode.ToString());
        //var result = await response.Content.ReadAsStringAsync();
        var result = await response.Content.ReadFromJsonAsync<TResponse>();
        return result;
    }

    public Task<GeoServerAboutVersionResponse> GetVersionAsync() =>
        GetAsync<GeoServerAboutVersionResponse>(ApiConsts.Endpoints.About.VersionApiPath);

    public Task<GeoServerAboutManifestResponse> GetManifestAsync() =>
        GetAsync<GeoServerAboutManifestResponse>(ApiConsts.Endpoints.About.ManifestApiPath);

    public Task<GeoServerAboutSystemStatusResponse> GetSystemStatusAsync() =>
        GetAsync<GeoServerAboutSystemStatusResponse>(ApiConsts.Endpoints.About.SystemStatusApiPath);

    public Task<GeoServerLayersListResponse> GetLayersListAsync() =>
        GetAsync<GeoServerLayersListResponse>(ApiConsts.Endpoints.Layers.GetLayersApiPath);
    
    public Task<GeoServerFontsListResponse> GetFontsListAsync() =>
        GetAsync<GeoServerFontsListResponse>(ApiConsts.Endpoints.Fonts.GetFontsApiPath);

    public Task<GeoServerNamespacesListResponse> GetNamespacesListAsync() =>
        GetAsync<GeoServerNamespacesListResponse>(ApiConsts.Endpoints.Namespaces.GetNamespacesApiPath);

    public Task<GeoServerStylesListResponse> GetStylesListAsync() =>
        GetAsync<GeoServerStylesListResponse>(ApiConsts.Endpoints.Styles.GetStylesApiPath);
}