using System;
using System.Buffers.Text;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
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

        public static T Deserialize<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json, Options);
        }

        public static ValueTask<T> DeserializeAsync<T>(Stream stream)
        {
            return JsonSerializer.DeserializeAsync<T>(stream, Options);
        }
    }
}
