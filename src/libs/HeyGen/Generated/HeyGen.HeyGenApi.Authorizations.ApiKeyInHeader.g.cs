
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

            _authorization = new global::HeyGen.EndPointAuthorization
            {
                Name = "X-Api-Key",
                Value = apiKey,
            };
        }
    }
}