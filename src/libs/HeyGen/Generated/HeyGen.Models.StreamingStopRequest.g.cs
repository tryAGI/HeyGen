
#nullable enable

namespace HeyGen
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamingStopRequest
    {
        /// <summary>
        /// Example: &lt;session_id&gt;
        /// </summary>
        /// <example>&lt;session_id&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingStopRequest" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Example: &lt;session_id&gt;
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StreamingStopRequest(
            string? sessionId)
        {
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingStopRequest" /> class.
        /// </summary>
        public StreamingStopRequest()
        {
        }
    }
}