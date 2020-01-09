using System.Text.Json.Serialization;

namespace Alexa.NET.Response.Directive.Templates.Types
{
    public class BodyTemplate3:IBodyTemplate
    {
        public string Type => "BodyTemplate3";
        public string Token { get; set; }

        [JsonPropertyName("backButton")]
        public string BackButton { get; set; }

        [JsonPropertyName("backgroundImage")]
        public TemplateImage BackgroundImage { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("image")]
        public TemplateImage Image { get; set; }

        [JsonPropertyName("textContent")]
        public TemplateContent Content { get; set; }
    }
}
