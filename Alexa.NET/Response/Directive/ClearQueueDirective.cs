using System.Text.Json.Serialization;
using Alexa.NET.Response.Converters;

namespace Alexa.NET.Response.Directive
{
    public class ClearQueueDirective : IDirective
    {
        [JsonPropertyName("type")]
        public string Type => "AudioPlayer.ClearQueue";

        [JsonPropertyName("clearBehavior")]
        //[JsonRequired]
        [JsonConverter(typeof(EnumMemberStringConverter))]
        public ClearBehavior ClearBehavior { get; set; }
    }
}
