using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Alexa.NET.Response.Directive.Templates
{
    public class TemplateImage
    {
        [JsonPropertyName("contentDescription")]//, Required = Required.Always)]
        public string ContentDescription { get; set; }

        [JsonPropertyName("sources")]
        public List<ImageSource> Sources {get;set;} = new List<ImageSource>();
    }
}