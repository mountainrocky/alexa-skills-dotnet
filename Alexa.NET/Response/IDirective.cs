using System.Text.Json.Serialization;
using Alexa.NET.Response.Converters;

namespace Alexa.NET.Response
{
    public interface IDirective
    {
        //[JsonRequired]
        string Type { get; }
    }
}