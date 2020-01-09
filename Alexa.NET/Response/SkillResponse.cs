using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Alexa.NET.Response
{
    public class SkillResponse
    {
        //[JsonRequired]
        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("sessionAttributes")]
        public Dictionary<string, object> SessionAttributes { get; set; }

        //[JsonRequired]
        [JsonPropertyName("response")]
        public ResponseBody Response { get; set; }
    }
}