using System.Text.Json.Serialization;
using Alexa.NET.Response.Converters;

namespace Alexa.NET.Response.Directive
{
    public class AudioPlayerPlayDirective : IDirective
    {
        [JsonPropertyName("playBehavior")]
        //[JsonRequired]
        [JsonConverter(typeof(EnumMemberStringConverter<PlayBehavior>))]
        public PlayBehavior PlayBehavior { get; set; }

        [JsonPropertyName("audioItem")]
        //[JsonRequired]
        public AudioItem AudioItem { get; set; }

        [JsonPropertyName("type")]
        public string Type => "AudioPlayer.Play";
    }
}
