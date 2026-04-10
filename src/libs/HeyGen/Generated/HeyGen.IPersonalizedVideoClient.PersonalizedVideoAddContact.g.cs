#nullable enable

namespace HeyGen
{
    public partial interface IPersonalizedVideoClient
    {
        /// <summary>
        /// personalized_video/add_contact<br/>
        /// personalized_video/add_contact
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HeyGen.ApiException"></exception>
        global::System.Threading.Tasks.Task PersonalizedVideoAddContactAsync(

            global::HeyGen.PersonalizedVideoAddContactRequest request,
            global::HeyGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// personalized_video/add_contact<br/>
        /// personalized_video/add_contact
        /// </summary>
        /// <param name="projectId">
        /// Example: &lt;project_id&gt;
        /// </param>
        /// <param name="variablesList">
        /// Example: [{"email":"john@mail.com","first_name":"John"}]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PersonalizedVideoAddContactAsync(
            string? projectId = default,
            global::System.Collections.Generic.IList<global::HeyGen.PersonalizedVideoAddContactRequestVariablesListItem>? variablesList = default,
            global::HeyGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}