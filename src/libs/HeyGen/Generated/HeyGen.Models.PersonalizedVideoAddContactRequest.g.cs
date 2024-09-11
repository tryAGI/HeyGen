
#nullable enable

namespace HeyGen
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PersonalizedVideoAddContactRequest
    {
        /// <summary>
        /// Example: &lt;project_id&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Example: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables_list")]
        public global::System.Collections.Generic.IList<global::HeyGen.PersonalizedVideoAddContactRequestVariablesListItem>? VariablesList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}