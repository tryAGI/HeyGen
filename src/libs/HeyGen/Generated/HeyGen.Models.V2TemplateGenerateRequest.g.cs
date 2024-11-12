
#nullable enable

namespace HeyGen
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2TemplateGenerateRequest
    {
        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption")]
        public bool? Caption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public global::HeyGen.V2TemplateGenerateRequestDimension? Dimension { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("test")]
        public bool? Test { get; set; }

        /// <summary>
        /// Example: New Video
        /// </summary>
        /// <example>New Video</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::HeyGen.V2TemplateGenerateRequestVariables? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2TemplateGenerateRequest" /> class.
        /// </summary>
        /// <param name="caption">
        /// Example: false
        /// </param>
        /// <param name="dimension"></param>
        /// <param name="test">
        /// Example: false
        /// </param>
        /// <param name="title">
        /// Example: New Video
        /// </param>
        /// <param name="variables"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public V2TemplateGenerateRequest(
            bool? caption,
            global::HeyGen.V2TemplateGenerateRequestDimension? dimension,
            bool? test,
            string? title,
            global::HeyGen.V2TemplateGenerateRequestVariables? variables)
        {
            this.Caption = caption;
            this.Dimension = dimension;
            this.Test = test;
            this.Title = title;
            this.Variables = variables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2TemplateGenerateRequest" /> class.
        /// </summary>
        public V2TemplateGenerateRequest()
        {
        }
    }
}