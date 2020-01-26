using System.Text.Json.Serialization;
using Alexa.NET.Response.Converters;

namespace Alexa.NET.Response.Directive
{
    public interface ITemplate
    {
        [JsonPropertyName("type")]//, Required = Required.Always)]
        string Type { get; }

        [JsonPropertyName("token")]
        string Token { get; set; }
    }
}