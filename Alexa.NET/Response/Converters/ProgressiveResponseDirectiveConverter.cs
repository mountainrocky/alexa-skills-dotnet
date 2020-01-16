using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.Directive;

namespace Alexa.NET.Response.Converters
{
    public class ProgressiveResponseDirectiveConverter : TypeJsonConverter<IProgressiveResponseDirective>
    {
        public static Dictionary<string, Func<IProgressiveResponseDirective>> TypeFactories =
            new Dictionary<string, Func<IProgressiveResponseDirective>>
            {
                {"VoicePlayer.Speak", () => new VoicePlayerSpeakDirective()}
            };

        public ProgressiveResponseDirectiveConverter() : base(TypeFactories)
        {
        }
    };
}
