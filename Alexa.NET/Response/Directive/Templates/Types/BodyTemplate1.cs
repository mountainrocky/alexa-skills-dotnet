using System.Text.Json.Serialization;

namespace Alexa.NET.Response.Directive.Templates.Types
{
    public class BodyTemplate1:IBodyTemplate
    {
        [JsonPropertyName("type")]
        public string Type => "BodyTemplate1";
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("backButton")]
        public string BackButton { get; set; }

        [JsonPropertyName("backgroundImage")]
        public TemplateImage BackgroundImage { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("textContent")]
        public TemplateContent Content { get; set; }
    }
}
