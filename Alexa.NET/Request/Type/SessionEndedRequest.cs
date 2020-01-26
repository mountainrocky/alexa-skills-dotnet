using System.Text.Json.Serialization;
using Alexa.NET.Response.Converters;

namespace Alexa.NET.Request.Type
{
    public class SessionEndedRequest : Request
    {
        [JsonPropertyName("reason")]
        [JsonConverter(typeof(EnumMemberStringConverter<Reason>))]
        public Reason Reason { get; set; }

        [JsonPropertyName("error")]//,NullValueHandling=NullValueHandling.Ignore)]
        public Error Error { get; set; }
    }
}