using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Alexa.NET.Response.Converters
{
    public abstract class DiscriminatorJsonConverter<T>:JsonConverter<T>
    {
        protected DiscriminatorJsonConverter(string propertyName, Func<string, Type> typeConverter)
        {
            PropertyName = propertyName;
            TypeConverter = typeConverter;
        }

        public static T LoadFromDiscriminator(ref Utf8JsonReader reader, string propertyName, Func<string,Type> converter,JsonSerializerOptions options)
        {
            var dReader = reader;
            if (dReader.TokenType != JsonTokenType.StartObject)
            {
                throw new InvalidOperationException("Bad position for a JSON object");
            }

            while (dReader.TokenType != JsonTokenType.EndObject && dReader.TokenType != JsonTokenType.PropertyName)
            {
                dReader.Read();
            }

            if (dReader.TokenType == JsonTokenType.EndObject)
            {
                throw new InvalidOperationException($"Unable to find {propertyName} discriminator");
            }

            dReader.Read();
            var discriminator = dReader.GetString();
            var type = converter(discriminator);
            return (T)JsonSerializer.Deserialize(ref reader, type, options);
        }

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return LoadFromDiscriminator(ref reader, PropertyName, TypeConverter, options);
        }

        public string PropertyName { get; }
        public Func<string,Type> TypeConverter { get; }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsAssignableFrom(typeof(T));
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.GetType(), options);
        }
    }
}
