#nullable enable

namespace HeyGen
{
    public partial interface IStreamingAPIClient
    {
        /// <summary>
        /// streaming.stop<br/>
        /// streaming.stop
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task StreamingStopAsync(
            global::HeyGen.StreamingStopRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// streaming.stop<br/>
        /// streaming.stop
        /// </summary>
        /// <param name="sessionId">
        /// Example: &lt;session_id&gt;
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task StreamingStopAsync(
            string? sessionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}