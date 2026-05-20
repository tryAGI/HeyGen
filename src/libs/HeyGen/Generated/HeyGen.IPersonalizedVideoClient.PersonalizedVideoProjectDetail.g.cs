#nullable enable

namespace HeyGen
{
    public partial interface IPersonalizedVideoClient
    {
        /// <summary>
        /// personalized_video/project/detail<br/>
        /// personalized_video/project/detail
        /// </summary>
        /// <param name="id">
        /// Example: &lt;project-id&gt;
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task PersonalizedVideoProjectDetailAsync(
            string? id = default,
            global::HeyGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// personalized_video/project/detail<br/>
        /// personalized_video/project/detail
        /// </summary>
        /// <param name="id">
        /// Example: &lt;project-id&gt;
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HeyGen.AutoSDKHttpResponse> PersonalizedVideoProjectDetailAsResponseAsync(
            string? id = default,
            global::HeyGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}