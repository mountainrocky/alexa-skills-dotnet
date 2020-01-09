using System.Text.Json.Serialization;
using Alexa.NET.Response.Converters;
using Alexa.NET.Response.Directive;

namespace Alexa.NET.Response
{
    public interface IOutputSpeech : IResponse
    {
        PlayBehavior? PlayBehavior { get; set; }
    }
}