using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Alexa.NET.Response.Directive.Templates.Types
{
    public class ListTemplate1:IListTemplate
    {
        [JsonPropertyName("type")]
        public string Type => "ListTemplate1";
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("backButton")]
        public string BackButton { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("backgroundImage")]
        public TemplateImage BackgroundImage { get; set; }

        [JsonPropertyName("listItems")]
        public List<ListItem> Items { get; set; } = new List<ListItem>();

        public bool ShouldSerializeItems()
        {
            return Items.Count > 0;
        }
    }
}
