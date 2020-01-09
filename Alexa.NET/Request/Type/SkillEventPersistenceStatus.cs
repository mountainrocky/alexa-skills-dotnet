using System.Text.Json.Serialization;
using Alexa.NET.Response.Converters;

namespace Alexa.NET.Request.Type
{
    public class SkillEventPersistenceStatus
    {
        [JsonPropertyName("userInformationPersistenceStatus"),
         JsonConverter(typeof(EnumMemberStringConverter))]
        public PersistenceStatus Status { get; set; }
    }
}