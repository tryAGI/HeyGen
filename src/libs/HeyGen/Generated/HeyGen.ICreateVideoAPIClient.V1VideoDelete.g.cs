#nullable enable

namespace HeyGen
{
    public partial interface ICreateVideoAPIClient
    {
        /// <summary>
        /// v1/video.delete<br/>
        /// v1/video.delete
        /// </summary>
        /// <param name="videoId">
        /// Example: &lt;video_id&gt;
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V1VideoDeleteAsync(
            string? videoId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}