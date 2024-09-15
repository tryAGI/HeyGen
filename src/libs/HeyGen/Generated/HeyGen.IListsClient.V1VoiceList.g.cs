#nullable enable

namespace HeyGen
{
    public partial interface IListsClient
    {
        /// <summary>
        /// v1/voice.list<br/>
        /// v1/voice.list
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V1VoiceListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}