#nullable enable

namespace HeyGen
{
    public partial interface ICreateVideoAPIClient
    {
        /// <summary>
        /// v2/video/generate<br/>
        /// Generated Video: [https://app.heygen.com/share/67cd13935445457eaa99040070bdb545](https://app.heygen.com/share/67cd13935445457eaa99040070bdb545)<br/>
        /// &lt;img src="https://resource.heygen.ai/video/gifs/67cd13935445457eaa99040070bdb545.gif" alt=""&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task V2VideoGenerateAsync(
            global::HeyGen.V2VideoGenerateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// v2/video/generate<br/>
        /// Generated Video: [https://app.heygen.com/share/67cd13935445457eaa99040070bdb545](https://app.heygen.com/share/67cd13935445457eaa99040070bdb545)<br/>
        /// &lt;img src="https://resource.heygen.ai/video/gifs/67cd13935445457eaa99040070bdb545.gif" alt=""&gt;
        /// </summary>
        /// <param name="aspectRatio"></param>
        /// <param name="callbackId"></param>
        /// <param name="dimension"></param>
        /// <param name="test">
        /// Example: true
        /// </param>
        /// <param name="title">
        /// Example: My Title
        /// </param>
        /// <param name="videoInputs">
        /// Example: [{"character":{"avatar_id":"Kristin_public_3_20240108","avatar_style":"normal","type":"avatar"},"voice":{"input_text":"Welcome to the new era of video creation with HeyGen! Simply type your script to get started!","type":"text","voice_id":"2f72ee82b83d4b00af16c4771d611752"}}]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V2VideoGenerateAsync(
            object? aspectRatio = default,
            object? callbackId = default,
            global::HeyGen.V2VideoGenerateRequestDimension? dimension = default,
            bool? test = default,
            string? title = default,
            global::System.Collections.Generic.IList<global::HeyGen.V2VideoGenerateRequestVideoInput>? videoInputs = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}