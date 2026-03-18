
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace HeyGen
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::HeyGen.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.V2VideoGenerateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.V2VideoGenerateRequestDimension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HeyGen.V2VideoGenerateRequestVideoInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.V2VideoGenerateRequestVideoInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.V2VideoGenerateRequestVideoInputCharacter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.V2VideoGenerateRequestVideoInputVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.V2TemplateGenerateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.V2TemplateGenerateRequestDimension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.V2TemplateGenerateRequestVariables))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.V2TemplateGenerateRequestVariablesFirstName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.V2TemplateGenerateRequestVariablesFirstNameProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.V2VideoTranslateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.StreamingNewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.StreamingStartRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.StreamingStartRequestSdp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.StreamingIceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.StreamingIceRequestCandidate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.StreamingTaskRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.StreamingStopRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.StreamingInterruptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.V1WebhookEndpointAddRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.PersonalizedVideoAddContactRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HeyGen.PersonalizedVideoAddContactRequestVariablesListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HeyGen.PersonalizedVideoAddContactRequestVariablesListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HeyGen.V2VideoGenerateRequestVideoInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HeyGen.PersonalizedVideoAddContactRequestVariablesListItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}