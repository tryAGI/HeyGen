#nullable enable

namespace HeyGen
{
    public partial interface IStreamingAPIClient
    {
        /// <summary>
        /// streaming/avatar.list<br/>
        /// streaming/avatar.list
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task StreamingAvatarListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}