using System.Text.Json.Serialization;

namespace Alexa.NET.Response
{
    public class StandardCard : ICard
    {
        //[JsonRequired]
        [JsonPropertyName("type")]
        public string Type
        {
            get { return "Standard"; }
        }

        //[JsonRequired]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        //[JsonRequired]
        [JsonPropertyName("text")]
        public string Content { get; set; }

        [JsonPropertyName("image")]
        public CardImage Image { get; set; }
    }
}
