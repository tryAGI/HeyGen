#nullable enable

namespace HeyGen
{
    public partial interface IStreamingAPIClient
    {
        /// <summary>
        /// streaming.start<br/>
        /// streaming.start
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task StreamingStartAsync(
            global::HeyGen.StreamingStartRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// streaming.start<br/>
        /// streaming.start
        /// </summary>
        /// <param name="sdp"></param>
        /// <param name="sessionId">
        /// Example: f8c1f5bd-edbd-11ee-ac61-06daf6be75b4
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task StreamingStartAsync(
            global::HeyGen.StreamingStartRequestSdp? sdp = default,
            string? sessionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}