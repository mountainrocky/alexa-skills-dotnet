using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Alexa.NET.Response
{
    public class AskForPermissionsConsentCard : ICard
    {

        [JsonPropertyName("type")]
        //[JsonRequired]
        public string Type
        {
            get { return "AskForPermissionsConsent"; }
        }

        [JsonPropertyName("permissions")]
        //[JsonRequired]
        public List<string> Permissions { get; set; } = new List<string>();
    }
}
