#nullable enable

namespace HeyGen
{
    public partial interface ITemplateApiClient
    {
        /// <summary>
        /// v2/template/generate<br/>
        /// Generated Video: [https://app.heygen.com/videos/7cba9d29d6db46b88471221fdbc4fb75](https://app.heygen.com/videos/7cba9d29d6db46b88471221fdbc4fb75)<br/>
        /// &lt;img src="https://resource.heygen.ai/video/gifs/7cba9d29d6db46b88471221fdbc4fb75.gif" alt=""&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task V2TemplateGenerateAsync(

            global::HeyGen.V2TemplateGenerateRequest request,
            global::HeyGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// v2/template/generate<br/>
        /// Generated Video: [https://app.heygen.com/videos/7cba9d29d6db46b88471221fdbc4fb75](https://app.heygen.com/videos/7cba9d29d6db46b88471221fdbc4fb75)<br/>
        /// &lt;img src="https://resource.heygen.ai/video/gifs/7cba9d29d6db46b88471221fdbc4fb75.gif" alt=""&gt;
        /// </summary>
        /// <param name="caption">
        /// Example: false
        /// </param>
        /// <param name="dimension"></param>
        /// <param name="test">
        /// Example: false
        /// </param>
        /// <param name="title">
        /// Example: New Video
        /// </param>
        /// <param name="variables"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V2TemplateGenerateAsync(
            bool? caption = default,
            global::HeyGen.V2TemplateGenerateRequestDimension? dimension = default,
            bool? test = default,
            string? title = default,
            global::HeyGen.V2TemplateGenerateRequestVariables? variables = default,
            global::HeyGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}