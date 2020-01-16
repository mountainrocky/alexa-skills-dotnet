using System.Text.Json.Serialization;

namespace Alexa.NET.Response.Directive.Templates
{
    public class ImageSource
    {
        [JsonPropertyName("url")]//, Required = Required.Always)]
        public string Url { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("widthPixels")]
        public int? Width { get; set; }

        [JsonPropertyName("heightPixels")]
        public int? Height { get; set; }
    }
}