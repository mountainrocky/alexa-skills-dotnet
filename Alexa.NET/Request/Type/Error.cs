using System.Text.Json.Serialization;
using Alexa.NET.Response.Converters;

namespace Alexa.NET.Request.Type
{
    public class Error
    {
        [JsonPropertyName("type")]
        [JsonConverter(typeof(EnumMemberStringConverter))]
        public ErrorType Type { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
