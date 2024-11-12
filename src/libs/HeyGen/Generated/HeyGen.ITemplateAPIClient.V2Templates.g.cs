#nullable enable

namespace HeyGen
{
    public partial interface ITemplateAPIClient
    {
        /// <summary>
        /// v2/templates<br/>
        /// v2/templates
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task V2TemplatesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}