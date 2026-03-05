#nullable enable

namespace HeyGen
{
    public partial interface IVideoTranslateApiClient
    {
        /// <summary>
        /// v2/video_translate/&lt;id&gt; (status)<br/>
        /// v2/video_translate/&lt;id&gt; (status)
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task V2VideoTranslateIdStatusAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}