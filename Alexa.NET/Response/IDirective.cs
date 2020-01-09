using System.Text.Json.Serialization;

namespace Alexa.NET.Response
{
    //[JsonConverter(typeof(DirectiveConverter))]
    public interface IDirective
    {
        //[JsonRequired]
        string Type { get; }
    }
}