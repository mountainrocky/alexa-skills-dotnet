using System.Text.Json.Serialization;

using System;
using System.Collections.Generic;

namespace Alexa.NET.Response.Converters
{
    public class CardConverter : TypeJsonConverter<ICard>
    {
        public CardConverter() : base(TypeFactories)
        {

        }
        public static Dictionary<string, Func<ICard>> TypeFactories = new Dictionary<string, Func<ICard>>
        {
            { "Simple", () => new SimpleCard() },
            { "Standard", () => new StandardCard() },
            { "LinkAccount", () => new LinkAccountCard() },
            { "AskForPermissionsConsent", () => new AskForPermissionsConsentCard() }
        };
    }
}