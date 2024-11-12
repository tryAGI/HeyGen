#nullable enable

namespace HeyGen
{
    public partial interface IStreamingAPIClient
    {
        /// <summary>
        /// streaming.new<br/>
        /// streaming.new
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task StreamingNewAsync(
            global::HeyGen.StreamingNewRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// streaming.new<br/>
        /// streaming.new
        /// </summary>
        /// <param name="quality">
        /// Example: medium
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task StreamingNewAsync(
            string? quality = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}