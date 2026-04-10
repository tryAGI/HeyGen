#nullable enable

namespace HeyGen
{
    public partial interface IStreamingApiClient
    {
        /// <summary>
        /// streaming.new<br/>
        /// streaming.new
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task StreamingNewAsync(

            global::HeyGen.StreamingNewRequest request,
            global::HeyGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// streaming.new<br/>
        /// streaming.new
        /// </summary>
        /// <param name="quality">
        /// Example: medium
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task StreamingNewAsync(
            string? quality = default,
            global::HeyGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}