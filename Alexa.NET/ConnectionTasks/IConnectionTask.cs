using Alexa.NET.Response.Converters;
using System.Text.Json.Serialization;

namespace Alexa.NET.ConnectionTasks
{
    //[JsonConverter(typeof(ConnectionTaskConverter))]
    public interface IConnectionTask
    {
        [JsonIgnore]
        string ConnectionUri { get; }

        [JsonPropertyName("@type")]
        string Type { get; }

        [JsonPropertyName("@version")]
        string Version { get; }

        [JsonPropertyName("context")]
        ConnectionTaskContext Context { get; set; }
    }
}
