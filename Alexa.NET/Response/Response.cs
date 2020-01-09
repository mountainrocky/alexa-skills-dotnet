using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Alexa.NET.Response
{
    public class ResponseBody
    {
        [JsonPropertyName("outputSpeech")]
        public IOutputSpeech OutputSpeech { get; set; }

        [JsonPropertyName("card")]
        public ICard Card { get; set; }

        [JsonPropertyName("reprompt")]
        public Reprompt Reprompt { get; set; }

        [JsonPropertyName("shouldEndSession")]
        public bool? ShouldEndSession { get; set; } = false;

        [JsonPropertyName("directives")]
        public IList<IDirective> Directives { get; set; } = new List<IDirective>();

        //Not implemented in JSON.Net
        //public bool ShouldSerializeDirectives()
        //{
        //    return Directives.Count > 0;
        //}
    }
}
