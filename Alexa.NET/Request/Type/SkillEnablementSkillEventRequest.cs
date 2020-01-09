using System.Text.Json.Serialization;

namespace Alexa.NET.Request.Type
{
    public class SkillEnablementSkillEventRequest: SkillEventRequest
    {
        [JsonPropertyName("body")]
        public SkillEventPersistenceStatus Body { get; set; }
    }
}
