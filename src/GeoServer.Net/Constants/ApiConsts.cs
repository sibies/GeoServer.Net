namespace GeoServer.Net.Constants;

public static class ApiConsts
{
    public const string Version = "2.24.1";
    public const string OutputFormat = ".json";

    public static class Endpoints
    {
        //public const string BaseApiUrl = "http://localhost:8080/geoserver";
        //public const string BaseApiPath = BaseApiUrl + "/rest";
        public const string BaseApiPath = "/rest";

        /// <summary>
        /// The REST API allows you to set and retrieve information about the server itself.
        /// </summary>
        public static class About
        {
            public const string BaseAboutApiPath = BaseApiPath + "/about";

            public const string VersionApiPath = BaseAboutApiPath + "/version" + OutputFormat;
            public const string ManifestApiPath = BaseAboutApiPath + "/manifest" + OutputFormat;
            public const string SystemStatusApiPath = BaseAboutApiPath + "/system-status" + OutputFormat;
        }

        public static class Layers
        {
            public const string BaseLayersApiPath = BaseApiPath + "/layers";
            public const string GetLayersApiPath = BaseLayersApiPath + OutputFormat;

        }

        public static class Fonts
        {
            public const string BaseFontsApiPath = BaseApiPath + "/fonts";
            public const string GetFontsApiPath = BaseFontsApiPath + OutputFormat;

        }

        public static class Namespaces
        {
            public const string BaseNamespacesApiPath = BaseApiPath + "/namespaces";
            public const string GetNamespacesApiPath = BaseNamespacesApiPath + OutputFormat;

        }
    }

}