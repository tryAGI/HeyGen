namespace HeyGen.IntegrationTests;

[TestClass]
public partial class Tests
{
    public HeyGenClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("HEYGEN_API_KEY") ??
            throw new AssertInconclusiveException("HEYGEN_API_KEY environment variable is not found.");

        var api = new HeyGenClient(apiKey);
        
        return api;
    }
}
