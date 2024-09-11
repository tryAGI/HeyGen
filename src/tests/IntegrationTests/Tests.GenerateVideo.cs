namespace HeyGen.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GenerateVideo()
    {
        // https://app.heygen.com/settings?nav=API
        // Your Trial Token can be used to test the following HeyGen APIs at no charge:
        // Video Generation: Create up to 5 watermarked videos per day. Documentation.
        // Interactive Avatar: Create up to 3 concurrent Streaming sessions; up to 300 minutes per month. Documentation.
        using var api = GetAuthenticatedApi();

        await api.CreateVideoAPI.V2VideoGenerateAsync(
            title: "title",
            test: true,
            dimension: new V2VideoGenerateRequestDimension
            {
                Width = 1920,
                Height = 1080,
            },
            aspectRatio: new V2VideoGenerateRequestAspectRatio(),
            callbackId: new V2VideoGenerateRequestCallbackId(),
            videoInputs: new List<V2VideoGenerateRequestVideoInput>
            {
                new()
                {
                    Character = new V2VideoGenerateRequestVideoInputCharacter
                    {
                        AvatarId = "avatarId",
                        AvatarStyle = "avatarStyle",
                        Type = "type",
                    },
                    Voice = new V2VideoGenerateRequestVideoInputVoice
                    {
                        InputText = "inputText",
                        Type = "type",
                        VoiceId = "voiceId",
                    },
                }
            });
    }
}
