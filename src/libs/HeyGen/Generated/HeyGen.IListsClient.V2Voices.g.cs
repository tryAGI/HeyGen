#nullable enable

namespace HeyGen
{
    public partial interface IListsClient
    {
        /// <summary>
        /// v2/voices<br/>
        /// v2/voices
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V2VoicesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}