namespace GeoServer.Net.Contracts;

public interface IGeoServerClient : 
    IGeoServerAboutClient, 
    IGeoServerLayersClient, 
    IGeoServerFontClient, 
    IGeoServerNamespaceClient, 
    IGeoServerStyleClient;