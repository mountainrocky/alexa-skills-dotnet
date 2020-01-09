using System.Text.Json.Serialization;

namespace Alexa.NET.Response.Directive.Templates
{
    public class TemplateText
    {
        [JsonPropertyName("text")]//, Required = Required.Always)]
        public string Text { get; set; }

        [JsonPropertyName("type")]//, Required = Required.Always)]
        public string Type { get; set; }
    }
}
