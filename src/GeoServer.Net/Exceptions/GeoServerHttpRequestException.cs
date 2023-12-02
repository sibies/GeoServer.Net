namespace GeoServer.Net.Exceptions;

public class GeoServerHttpRequestException(string message) : HttpRequestException(message);