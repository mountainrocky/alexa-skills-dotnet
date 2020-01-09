using System.Text.Json.Serialization;

namespace Alexa.NET.Request.Type
{
    public class ErrorCause
    {
        [JsonPropertyName("requestId")]
        public string requestId { get; set; }
    }
}
