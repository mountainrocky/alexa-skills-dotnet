using System.Text.Json.Serialization;

namespace Alexa.NET.Request.Type
{
    public class IntentRequest : Request
    {
        [JsonPropertyName("dialogState")]
        public string DialogState { get; set; }

        public Intent Intent { get; set; }
    }
}