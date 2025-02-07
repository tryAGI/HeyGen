
#nullable enable

namespace HeyGen
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2VideoGenerateRequestVideoInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character")]
        public global::HeyGen.V2VideoGenerateRequestVideoInputCharacter? Character { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public global::HeyGen.V2VideoGenerateRequestVideoInputVoice? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2VideoGenerateRequestVideoInput" /> class.
        /// </summary>
        /// <param name="character"></param>
        /// <param name="voice"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2VideoGenerateRequestVideoInput(
            global::HeyGen.V2VideoGenerateRequestVideoInputCharacter? character,
            global::HeyGen.V2VideoGenerateRequestVideoInputVoice? voice)
        {
            this.Character = character;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2VideoGenerateRequestVideoInput" /> class.
        /// </summary>
        public V2VideoGenerateRequestVideoInput()
        {
        }
    }
}