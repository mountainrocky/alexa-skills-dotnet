using System.Text.Json.Serialization;
using Alexa.NET.Response.Directive;

namespace Alexa.NET.Response
{
    public class PlainTextOutputSpeech : IOutputSpeech
    {
        public PlainTextOutputSpeech()
        {

        }

        public PlainTextOutputSpeech(string text)
        {
            Text = text;
        }

        [JsonPropertyName("type")]
        //[JsonRequired]
        public string Type
        {
            get { return "PlainText"; }
        }

        //[JsonRequired]
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("playBehavior")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PlayBehavior? PlayBehavior { get; set; }
    }
}