using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Alexa.NET.Response.Converters
{
    public class OutputSpeechConverter : TypeJsonConverter<IOutputSpeech>
    {
        public OutputSpeechConverter() : base(TypeFactories)
        {

        }

        public static Dictionary<string, Func<IOutputSpeech>> TypeFactories = new Dictionary<string, Func<IOutputSpeech>>
        {
            { "SSML", () => new SsmlOutputSpeech() },
            { "PlainText", () => new PlainTextOutputSpeech() },
        };
    }
}