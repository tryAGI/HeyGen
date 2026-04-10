#nullable enable

namespace HeyGen
{
    public partial interface ITalkingPhotoClient
    {
        /// <summary>
        /// v1/talking_photo.list<br/>
        /// v1/talking_photo.list
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task V1TalkingPhotoListAsync(
            global::HeyGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}