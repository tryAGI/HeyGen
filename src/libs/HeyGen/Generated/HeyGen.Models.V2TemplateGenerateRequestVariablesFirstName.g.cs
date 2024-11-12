
#nullable enable

namespace HeyGen
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2TemplateGenerateRequestVariablesFirstName
    {
        /// <summary>
        /// Example: first_name
        /// </summary>
        /// <example>first_name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::HeyGen.V2TemplateGenerateRequestVariablesFirstNameProperties? Properties { get; set; }

        /// <summary>
        /// Example: text
        /// </summary>
        /// <example>text</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2TemplateGenerateRequestVariablesFirstName" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: first_name
        /// </param>
        /// <param name="properties"></param>
        /// <param name="type">
        /// Example: text
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public V2TemplateGenerateRequestVariablesFirstName(
            string? name,
            global::HeyGen.V2TemplateGenerateRequestVariablesFirstNameProperties? properties,
            string? type)
        {
            this.Name = name;
            this.Properties = properties;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2TemplateGenerateRequestVariablesFirstName" /> class.
        /// </summary>
        public V2TemplateGenerateRequestVariablesFirstName()
        {
        }
    }
}