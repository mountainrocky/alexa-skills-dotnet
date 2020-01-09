using System.Text.Json.Serialization;

namespace Alexa.NET.Response
{
    public class CardImage
    {
        //[JsonRequired]
        [JsonPropertyName("smallImageUrl")]
        public string SmallImageUrl { get; set; }

        //[JsonRequired]
        [JsonPropertyName("largeImageUrl")]
        public string LargeImageUrl { get; set; }
    }
}
