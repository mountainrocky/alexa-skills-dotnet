using System.Text.Json.Serialization;

namespace Alexa.NET.Response.Directive
{
    public class AudioPlayerPlayDirective : IDirective
    {
        [JsonPropertyName("playBehavior")]
        //[JsonRequired]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PlayBehavior PlayBehavior { get; set; }

        [JsonPropertyName("audioItem")]
        //[JsonRequired]
        public AudioItem AudioItem { get; set; }

        [JsonPropertyName("type")]
        public string Type => "AudioPlayer.Play";
    }
}
