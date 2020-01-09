using System.Text.Json.Serialization;
using Alexa.NET.Response.Directive;

namespace Alexa.NET.Response
{
    public class SsmlOutputSpeech : IOutputSpeech
    {
        public SsmlOutputSpeech()
        {

        }

        public SsmlOutputSpeech(string ssml)
        {
            Ssml = ssml;
        }

        //[JsonRequired]
        [JsonPropertyName("type")]
        public string Type
        {
            get { return "SSML"; }
        }

        //[JsonRequired]
        [JsonPropertyName("ssml")]
        public string Ssml { get; set; }

        [JsonPropertyName("playBehavior")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PlayBehavior? PlayBehavior { get; set; }
    }
}