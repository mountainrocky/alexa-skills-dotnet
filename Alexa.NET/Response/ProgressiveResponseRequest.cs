using System.Text.Json.Serialization;
using Alexa.NET.Response.Converters;

namespace Alexa.NET.Response
{
    public class ProgressiveResponseRequest
    {
        public ProgressiveResponseRequest()
        {
        }

        public ProgressiveResponseRequest(ProgressiveResponseHeader header, IProgressiveResponseDirective directive)
        {
            Header = header;
            Directive = directive;
        }

        [JsonPropertyName("header")]
        public ProgressiveResponseHeader Header { get; set; }

        [JsonPropertyName("directive")]
        public IProgressiveResponseDirective Directive { get; set; }
    }
}
