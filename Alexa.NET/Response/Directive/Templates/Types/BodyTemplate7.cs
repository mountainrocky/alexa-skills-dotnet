using System.Text.Json.Serialization;

namespace Alexa.NET.Response.Directive.Templates.Types
{
    public class BodyTemplate7:IBodyTemplate
    {
        [JsonPropertyName("type")]
        public string Type => "BodyTemplate7";
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("backButton")]
        public string BackButton { get; set; }

        [JsonPropertyName("backgroundImage")]
        public TemplateImage BackgroundImage { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("image")]
        public TemplateImage Image { get; set; }
    }
}
