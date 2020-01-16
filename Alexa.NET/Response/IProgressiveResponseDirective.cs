using System.Text.Json.Serialization;

namespace Alexa.NET.Response
{
    public interface IProgressiveResponseDirective
    {
        //[JsonRequired]
        [JsonPropertyName("type")]
        string Type { get; }
    }
}
