using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Alexa.NET.Response.Directive
{
    public interface IListTemplate : ITemplate
    {
        [JsonPropertyName("listItems")]//, Required = Required.Always)]
        List<ListItem> Items { get; set; }
    }
}
