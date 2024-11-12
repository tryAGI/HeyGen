#nullable enable

namespace HeyGen
{
    public partial interface IStreamingAPIClient
    {
        /// <summary>
        /// streaming.ice<br/>
        /// streaming.ice
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task StreamingIceAsync(
            global::HeyGen.StreamingIceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// streaming.ice<br/>
        /// streaming.ice
        /// </summary>
        /// <param name="candidate"></param>
        /// <param name="sessionId">
        /// Example: &lt;SESSION_ID&gt;
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task StreamingIceAsync(
            global::HeyGen.StreamingIceRequestCandidate? candidate = default,
            string? sessionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}