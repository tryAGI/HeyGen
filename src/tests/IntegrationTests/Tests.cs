namespace HeyGen.IntegrationTests;

[TestClass]
public partial class Tests
{
    public HeyGenApi GetAuthenticatedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("HEYGEN_API_KEY") ??
            throw new AssertInconclusiveException("HEYGEN_API_KEY environment variable is not found.");

        var api = new HeyGenApi(apiKey);
        
        return api;
    }
}
