#nullable enable

namespace HeyGen
{
    public partial interface IListsClient
    {
        /// <summary>
        /// v1/video.list<br/>
        /// v1/video.list
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task V1VideoListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}