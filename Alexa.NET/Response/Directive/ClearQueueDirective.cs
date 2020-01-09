using System.Text.Json.Serialization;

namespace Alexa.NET.Response.Directive
{
    public class ClearQueueDirective : IDirective
    {
        [JsonPropertyName("type")]
        public string Type => "AudioPlayer.ClearQueue";

        [JsonPropertyName("clearBehavior")]
        //[JsonRequired]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ClearBehavior ClearBehavior { get; set; }
    }
}
