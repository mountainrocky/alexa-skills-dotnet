using System.Text.Json.Serialization;

namespace Alexa.NET.Response.Directive
{
    public class DisplayRenderTemplateDirective : IDirective
    {
        [JsonPropertyName("type")]
        public string Type => "Display.RenderTemplate";

        [JsonPropertyName("template")]//, Required = Required.Always)]
        public ITemplate Template { get; set; }
    }
}