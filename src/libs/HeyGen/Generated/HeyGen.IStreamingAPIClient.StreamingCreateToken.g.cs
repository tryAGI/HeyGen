#nullable enable

namespace HeyGen
{
    public partial interface IStreamingAPIClient
    {
        /// <summary>
        /// streaming.create_token<br/>
        /// streaming.create_token
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task StreamingCreateTokenAsync(
            object request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// streaming.create_token<br/>
        /// streaming.create_token
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task StreamingCreateTokenAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}