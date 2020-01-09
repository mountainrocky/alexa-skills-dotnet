using System;
using System.Collections.Generic;
using System.Linq;
using Alexa.NET.Response.Converters;

namespace Alexa.NET.Request.Type
{
    public class RequestConverter : DiscriminatorJsonConverter<Request>
    {
        public RequestConverter() : base("type",s => Create(s).GetType()) { }

        public static readonly List<IRequestTypeConverter> RequestConverters = new List<IRequestTypeConverter>(new IRequestTypeConverter[]
        {
            new DefaultRequestTypeConverter(),
            new AudioPlayerRequestTypeConverter(),
            new PlaybackRequestTypeConverter(),
            new TemplateEventRequestTypeConverter(),
            new SkillEventRequestTypeConverter(),
            new SkillConnectionRequestTypeConverter()
        });
        
        public static Request Create(string requestType)
        {
            var converter = RequestConverters.FirstOrDefault(c => c.CanConvert(requestType));
            return converter?.Convert(requestType) ?? throw new ArgumentOutOfRangeException(nameof(Type), $"Unknown request type: {requestType}.");
        }
    }
}