using System.Text.Json;
using Alexa.NET.Response;
using Alexa.NET.Response.Converters;

namespace Alexa.NET
{
    public class AlexaNetSerializer
    {
        static AlexaNetSerializer()
        {
            Options = new JsonSerializerOptions();
            Options.Converters.Add(new ConnectionTaskConverter());
            Options.Converters.Add(new TemplateConverter());
            Options.Converters.Add(new DirectiveConverter());
            Options.Converters.Add(new OutputSpeechConverter());
            Options.Converters.Add(new CardConverter());
        }

        public static JsonSerializerOptions Options { get; }

        public static string Serialize(object request)
        {
            return JsonSerializer.Serialize(request, Options);
        }
    }
}
