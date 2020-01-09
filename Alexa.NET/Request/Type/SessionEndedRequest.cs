using System.Text.Json.Serialization;

namespace Alexa.NET.Request.Type
{
    public class SessionEndedRequest : Request
    {
        [JsonPropertyName("reason")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Reason Reason { get; set; }

        [JsonPropertyName("error")]//,NullValueHandling=NullValueHandling.Ignore)]
        public Error Error { get; set; }
    }
}