using FluentAssertions;
using GeoServer.Net.Contracts;

namespace GeoServer.Net.Tests;

public class LayersEndpointsTests
{
    private readonly IGeoServerLayersClient _geoServerClient = new GeoServerClient(GeneralConfigurations.GeoServerUrl, GeneralConfigurations.UserName, GeneralConfigurations.Password);

    [Fact]
    public async Task GetLayersListTest()
    {
        var response = await _geoServerClient.GetLayersListAsync();
        response.Should().NotBeNull();
        response.Layers.Layer.Length.Should().BeGreaterThan(0);
    }
}