#nullable enable

namespace HeyGen
{
    public partial interface IListsClient
    {
        /// <summary>
        /// v2/avatars<br/>
        /// v2/avatars
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task V2AvatarsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}