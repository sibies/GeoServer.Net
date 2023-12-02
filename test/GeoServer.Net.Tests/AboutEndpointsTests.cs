using FluentAssertions;
using GeoServer.Net.Contracts;

namespace GeoServer.Net.Tests;

public class AboutEndpointsTests
{
    private readonly IGeoServerAboutClient _geoServerClient = new GeoServerClient(GeneralConfigurations.GeoServerUrl, GeneralConfigurations.UserName, GeneralConfigurations.Password);

    [Fact]
    public async Task GetVersionTest()
    {
        var response = await _geoServerClient.GetVersionAsync();
        response.Should().NotBeNull();
        response.About.Resources.Length.Should().BeGreaterThan(0);
    }

    [Fact]
    public async Task GetManifestTest()
    {
        var response = await _geoServerClient.GetManifestAsync();
        response.Should().NotBeNull();
        response.About.Resources.Length.Should().BeGreaterThan(0);
    }

    [Fact]
    public async Task GetSystemStatusTest()
    {
        var response = await _geoServerClient.GetSystemStatusAsync();
        response.Should().NotBeNull();
        response.Metrics.Metric.Length.Should().BeGreaterThan(0);
    }
}