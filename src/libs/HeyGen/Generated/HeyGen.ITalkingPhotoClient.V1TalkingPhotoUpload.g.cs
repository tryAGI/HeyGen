#nullable enable

namespace HeyGen
{
    public partial interface ITalkingPhotoClient
    {
        /// <summary>
        /// v1/talking_photo (upload)<br/>
        /// v1/talking_photo (upload)
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V1TalkingPhotoUploadAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}