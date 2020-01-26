using System.Collections.Generic;
using System.Text.Json.Serialization;
using Alexa.NET.Response.Converters;

namespace Alexa.NET.Response.Directive
{
    public class DialogUpdateDynamicEntities : IDirective
    {
        [JsonPropertyName("type")]
        public string Type => "Dialog.UpdateDynamicEntities";

        [JsonPropertyName("updateBehavior"), JsonConverter(typeof(EnumMemberStringConverter<UpdateBehavior>))]
        public UpdateBehavior UpdateBehavior { get; set; }

        [JsonPropertyName("types")]
        public List<SlotType> Types { get; set; } = new List<SlotType>();
    }
}
