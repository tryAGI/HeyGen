namespace HeyGen.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task InteractiveAvatar()
    {
        // https://app.heygen.com/settings?nav=API
        // Your Trial Token can be used to test the following HeyGen APIs at no charge:
        // Video Generation: Create up to 5 watermarked videos per day. Documentation.
        // Interactive Avatar: Create up to 3 concurrent Streaming sessions; up to 300 minutes per month. Documentation.
        using var api = GetAuthenticatedApi();

        await api.StreamingAPI.StreamingCreateTokenAsync();
    }
}