using System.Text.Json.Serialization;

namespace Alexa.NET.Response.Directive
{
    public class StopDirective : IDirective
    {
        [JsonPropertyName("type")]
        public string Type => "AudioPlayer.Stop";
    }
}
