using System.Text.Json.Serialization;

namespace Alexa.NET.Request.Type
{
    public class Error
    {
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ErrorType Type { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
