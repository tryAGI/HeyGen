
#nullable enable

namespace HeyGen
{
    public sealed partial class HeyGenApi
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::HeyGen.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "X-Api-Key",
                Value = apiKey,
            });
        }
    }
}