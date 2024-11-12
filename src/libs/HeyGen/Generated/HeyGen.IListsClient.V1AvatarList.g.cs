#nullable enable

namespace HeyGen
{
    public partial interface IListsClient
    {
        /// <summary>
        /// v1/avatar.list<br/>
        /// v1/avatar.list
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task V1AvatarListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}