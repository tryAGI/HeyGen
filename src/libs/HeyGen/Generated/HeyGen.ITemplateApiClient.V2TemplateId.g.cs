#nullable enable

namespace HeyGen
{
    public partial interface ITemplateApiClient
    {
        /// <summary>
        /// v2/template/&lt;id&gt;<br/>
        /// v2/template/&lt;id&gt;
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task V2TemplateIdAsync(
            global::HeyGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}