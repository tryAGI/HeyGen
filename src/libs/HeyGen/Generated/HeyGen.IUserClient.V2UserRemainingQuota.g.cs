#nullable enable

namespace HeyGen
{
    public partial interface IUserClient
    {
        /// <summary>
        /// v2/user/remaining_quota<br/>
        /// v2/user/remaining_quota
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task V2UserRemainingQuotaAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}