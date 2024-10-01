
#nullable enable

namespace HeyGen
{
    public sealed partial class HeyGenApi
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _authorizations.Clear();
            _authorizations.Add(new global::HeyGen.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "X-Api-Key",
                Value = apiKey,
            });
        }
    }
}