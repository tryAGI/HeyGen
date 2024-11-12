#nullable enable

namespace HeyGen
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// v1/webhook/webhook.list<br/>
        /// v1/webhook/webhook.list
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task V1WebhookWebhookListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}